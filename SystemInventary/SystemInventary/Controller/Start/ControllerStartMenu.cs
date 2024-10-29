using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemInventary.View.StartMenu;
using System.IO;
using System.Drawing;
using SystemInventary.View.ProviderViews;
using SystemInventary.View.Inventory;
using SystemInventary.View.Employee;

namespace SystemInventary.Controller.Start
{
    internal class ControllerStartMenu
    {
        StartMenu objStartMenu;
        Form currentForm;

        public ControllerStartMenu(StartMenu view)
        {
            objStartMenu = view;

            objStartMenu.btnProviders.Click += new EventHandler(openProviders);
            objStartMenu.btnInventory.Click += new EventHandler(openInventory);
            objStartMenu.btnEmployee.Click += new EventHandler(openEmployees);
        }

        public void openEmployees(object sender, EventArgs e)
        {
            OpenForm<FrmEmployees>();
        }

        public void openInventory(object sender, EventArgs e)
        {
            OpenForm<FrmInventory>();
        }

        public void openProviders(object sender, EventArgs e) 
        {
            OpenForm<FrmProvider>();
        }


        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            //Se declara objeto de tipo form llamado formulario 
            Form form;
            //Se guarda en el panel contenedor del formulario principal todos los controles del formulario que se desea abrir <MyForm> posteriormente se guarda todo en el objeto de tipo formulario
            form = objStartMenu.ContainerPanel.Controls.OfType<MyForm>().FirstOrDefault();
            if (form == null)
            {
                //Deginimos un nuevo formulario para que se guarde como nuevo objeto MyForm
                form = new MyForm();
                //Especificamos que el formulario debe mostrarse como ventana
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                if (currentForm != null)
                {
                    //Se cierra el formulario actural para mostrar el nuevo formulario
                    currentForm.Close();
                    //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                    objStartMenu.ContainerPanel.Controls.Remove(currentForm);
                }
                //Se establece como nuevo formulario actual el formulario que se esta abriendo
                currentForm = form;
                //Agregamos los controles del nuevo formulario al panel contenedor
                objStartMenu.ContainerPanel.Controls.Add(form);
                objStartMenu.ContainerPanel.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }

        }

    }
}
