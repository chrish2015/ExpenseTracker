using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicInterfaceTutorial;

namespace ExpenseTracker
{
    class ContactsController
    {
        public void SaveContacts(TextBox[] contactsTextBox, RadioButtons[] radioButtons)
        {
            for (int i = 0; i < contactsTextBox.Length; i++)
            {
                var contact = contactsTextBox[i].Text;
                var checkedType = radioButtons[i].Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);
                if (contact.Trim() == "" || checkedType == null)
                {
                    MessageBox.Show(@"Please fill all the fields for contact : " + (i + 1), @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                using (var dbEntities = new ExpenseTrackerDBEntities())
                {
                    dbEntities.Contacts.Add(new Contact()
                    {
                        contactType = checkedType.Text,
                        contactName = contact.Trim()
                    });
                    dbEntities.SaveChanges();
                }
            }
            MessageBox.Show(@"Contacts Are Successfully Added", @"Success", MessageBoxButtons.OK);
        }
    }
}
