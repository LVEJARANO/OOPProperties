using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Index : System.Web.UI.Page
    {
        Car objCar1 = new Car();
        Car objCar2 = new Car();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            //Valores para el objeto Car 1
            objCar1.Color = TBColor1.Text; //Se asigna (set) el valor ingresado desde la caja de texto
            objCar1.EngineCylinderVolumen = Convert.ToInt32(TBCilindraje1.Text);//Se asigna (set) el valor ingresado desde la caja de texto
            objCar1.Model = Convert.ToInt32(TBModelo1.Text);//Se asigna (set) el valor ingresado desde la caja de texto
            LblMsj1.Text = objCar1.stop(); //Se obtiene (get) los valor ingresados desde las cajas de texto

            //Valores para el objeto Car 2
            objCar2.Color = TBColor2.Text; //Se asigna (set) el valor ingresado desde la caja de texto
            objCar2.EngineCylinderVolumen = Convert.ToInt32(TBCilindraje2.Text);//Se asigna (set) el valor ingresado desde la caja de texto
            objCar2.Model = Convert.ToInt32(TBModelo2.Text);//Se asigna (set) el valor ingresado desde la caja de texto
            LblMsj2.Text = objCar2.stop(); //Se obtiene (get) los valor ingresados desde las cajas de texto

        }
    }
}