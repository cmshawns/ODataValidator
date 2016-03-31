using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODataValidator
{
    using System.IO;
    using System.Xml;

    using Microsoft.Data.Edm;
    using Microsoft.Data.Edm.Csdl;
    using Microsoft.Data.Edm.Library;
    using Microsoft.Data.Edm.Validation;

    public partial class ODataValidator : Form
    {
        public ODataValidator()
        {
            InitializeComponent();
        }

        private void MetadataText_TextChanged(object sender, EventArgs e)
        {
            Validate.Enabled = MetadataText.TextLength > 0;
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            IEdmModel model;
            IEnumerable<EdmError> errors;

            using(var reader = new StringReader(MetadataText.Text))
            using (var xml = new XmlTextReader(reader))
            {
                if (EdmxReader.TryParse(xml, out model, out errors))
                {
                    if (model.Validate(out errors))
                    {
                        MessageBox.Show("Metadata is Valid!", "Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(
                            string.Join("\n", errors.Select(error => $"{error.ErrorCode}: {error.ErrorMessage} ({error.ErrorLocation.ToString()})")),
                            "Validation failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                else
                {
                    MessageBox.Show(
                        string.Join("\n", errors.Select(error => $"{error.ErrorCode}: {error.ErrorMessage} ({error.ErrorLocation.ToString()})")),
                        "Bad model",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }
    }
}
