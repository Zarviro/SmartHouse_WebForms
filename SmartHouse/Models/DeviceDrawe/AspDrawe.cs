using SmartHouse.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse.Models.DeviceDrawe
{
    public static class AspDrawe
    {
        // Tv
        public static Control Tv(Tv tv)
        {
            LinkButton linkButtonTv = new LinkButton() {CssClass="device-tv"};
            Panel panelContent = new Panel() {CssClass="content"};
            Panel panelProperty = new Panel() {CssClass="property"};
            Label labelChannel = new Label() {CssClass="channel"};
            Label labelChannelName = new Label() {CssClass="channel-name"};
            Panel panelVolume = new Panel() {CssClass="volume"};
            Label labelVolumeText = new Label() {CssClass="volume-text"};

            labelChannel.Text = "CHANNEL: " + Convert.ToByte(tv.Channel).ToString();
            labelChannelName.Text = tv.Channel.ToString();
            for(int i = 1; i <= tv.Volume; i++)
            {
                panelVolume.Controls.Add(new Panel() { CssClass = "level" });
            }

            panelVolume.Controls.Add(labelVolumeText);
            panelProperty.Controls.Add(panelVolume);
            panelProperty.Controls.Add(labelChannel);
            panelProperty.Controls.Add(labelChannelName);           
            panelContent.Controls.Add(panelProperty);
            linkButtonTv.Controls.Add(panelContent);
            linkButtonTv.Controls.Add(DeviceBg());

            linkButtonTv.Attributes.Add("data-device", (tv as Device).TypeDevice());
            linkButtonTv.Attributes.Add("data-id", tv.Id.ToString());

            return linkButtonTv;
        }

        // Fridge
        public static Control Fridge(Fridge fridge)
        {
            LinkButton linkButtonFridge = new LinkButton() { CssClass = "device-fridge" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelTemp1 = new Panel() { CssClass = "temp1" };
            Panel panelTmeter1 = new Panel() { CssClass = "tmeter" };
            Panel panelScale1 = new Panel() { CssClass = "scale" };
            Panel panelCircle1 = new Panel() { CssClass = "circle" };
            Label labelText1 = new Label() { CssClass = "text"};
            Label labelTextValue1 = new Label() { CssClass = "text-value"};
            Panel panelTemp2 = new Panel() { CssClass = "temp2" };
            Panel panelTmeter2 = new Panel() { CssClass = "tmeter" };
            Panel panelScale2 = new Panel() { CssClass = "scale" };
            Panel panelCircle2 = new Panel() { CssClass = "circle" };
            Label labelText2 = new Label() { CssClass = "text" };
            Label labelTextValue2 = new Label() { CssClass = "text-value" };

            panelScale1.Height = fridge.TempScaleInt(fridge.Temp1, 2);
            labelText1.Text = "TEMP 1:";
            labelText1.Width = 60;
            labelTextValue1.Text = fridge.Temp1.ToString();

            panelScale2.Height = fridge.TempScaleInt(fridge.Temp2, 5);
            labelText2.Text = "TEMP 2:";
            labelText2.Width = 60;
            labelTextValue2.Text = fridge.Temp2.ToString();

            panelTmeter2.Controls.Add(panelScale2);
            panelTmeter2.Controls.Add(panelCircle2);
            panelTemp2.Controls.Add(panelTmeter2);
            panelTemp2.Controls.Add(labelText2);
            panelTemp2.Controls.Add(labelTextValue2);

            panelTmeter1.Controls.Add(panelScale1);
            panelTmeter1.Controls.Add(panelCircle1);
            panelTemp1.Controls.Add(panelTmeter1);
            panelTemp1.Controls.Add(labelText1);
            panelTemp1.Controls.Add(labelTextValue1); 
            
            panelProperty.Controls.Add(panelTemp1);
            panelProperty.Controls.Add(panelTemp2);
            panelContent.Controls.Add(panelProperty);
            linkButtonFridge.Controls.Add(panelContent);
            linkButtonFridge.Controls.Add(DeviceBg());

            linkButtonFridge.Attributes.Add("data-device", (fridge as Device).TypeDevice());
            linkButtonFridge.Attributes.Add("data-id", fridge.Id.ToString());

            return linkButtonFridge;
        }


        // Lamp
        public static Control Lamp(Lamp lamp)
        {
            LinkButton linkButtonLamp = new LinkButton() { CssClass = "device-lamp" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelLampBg = new Panel() { CssClass = "lamp-bg" };
            Label labelText = new Label() { CssClass = "text" };
            Label labelTextValue = new Label() { CssClass = "text-value" };

            panelLampBg.Attributes.CssStyle.Add("opacity", lamp.BrightPercent(lamp.Bright));
            labelText.Text = "BRIGHT:";
            labelTextValue.Text = lamp.Bright.ToString();

            panelProperty.Controls.Add(panelLampBg);
            panelProperty.Controls.Add(labelText);
            panelProperty.Controls.Add(labelTextValue);
            panelContent.Controls.Add(panelProperty);
            linkButtonLamp.Controls.Add(panelContent);
            linkButtonLamp.Controls.Add(DeviceBg());

            linkButtonLamp.Attributes.Add("data-device", (lamp as Device).TypeDevice());
            linkButtonLamp.Attributes.Add("data-id", lamp.Id.ToString());

            return linkButtonLamp;
        }


        // Cooker
        public static Control Cooker(Cooker cooker)
        {
            LinkButton linkButtonCooker = new LinkButton() { CssClass = "device-cooker" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelStove1 = new Panel() { CssClass = "stove1" };
            Panel panelStove2 = new Panel() { CssClass = "stove2" };
            Panel panelStove3 = new Panel() { CssClass = "stove3" };
            Panel panelStove4 = new Panel() { CssClass = "stove4" };
            Panel panelTemp1 = new Panel() { CssClass = "temp1" };
            Panel panelTemp2 = new Panel() { CssClass = "temp2" };
            Panel panelTemp3 = new Panel() { CssClass = "temp3" };
            Panel panelTemp4 = new Panel() { CssClass = "temp4" };
            Label labelText1 = new Label() { CssClass = "text" };
            Label labelTextValue1 = new Label() { CssClass = "text-value" };
            Label labelText2 = new Label() { CssClass = "text" };
            Label labelTextValue2 = new Label() { CssClass = "text-value" };
            Label labelText3 = new Label() { CssClass = "text" };
            Label labelTextValue3 = new Label() { CssClass = "text-value" };
            Label labelText4 = new Label() { CssClass = "text" };
            Label labelTextValue4 = new Label() { CssClass = "text-value" };

            panelStove1.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp1, cooker.MaxTemp1));
            panelStove2.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp2, cooker.MaxTemp2));
            panelStove3.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp3, cooker.MaxTemp3));
            panelStove4.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp4, cooker.MaxTemp4));
            labelText1.Attributes.CssStyle.Add("display", "block");
            labelTextValue1.Attributes.CssStyle.Add("display", "block");
            labelText2.Attributes.CssStyle.Add("display", "block");
            labelTextValue2.Attributes.CssStyle.Add("display", "block"); 
            labelText3.Attributes.CssStyle.Add("display", "block");
            labelTextValue3.Attributes.CssStyle.Add("display", "block"); 
            labelText4.Attributes.CssStyle.Add("display", "block");
            labelTextValue4.Attributes.CssStyle.Add("display", "block");

            labelText1.Text = "TEMP1:";
            labelTextValue1.Text = cooker.Temp1.ToString();
            labelText2.Text = "TEMP2:";
            labelTextValue2.Text = cooker.Temp2.ToString();
            labelText3.Text = "TEMP3:";
            labelTextValue3.Text = cooker.Temp3.ToString();
            labelText4.Text = "TEMP4:";
            labelTextValue4.Text = cooker.Temp4.ToString();

            panelTemp1.Controls.Add(labelText1);
            panelTemp1.Controls.Add(labelTextValue1);
            panelTemp2.Controls.Add(labelText2);
            panelTemp2.Controls.Add(labelTextValue2);
            panelTemp3.Controls.Add(labelText3);
            panelTemp3.Controls.Add(labelTextValue3);
            panelTemp4.Controls.Add(labelText4);
            panelTemp4.Controls.Add(labelTextValue4);

            panelProperty.Controls.Add(panelStove1);
            panelProperty.Controls.Add(panelStove2);
            panelProperty.Controls.Add(panelStove3);
            panelProperty.Controls.Add(panelStove4);
            panelProperty.Controls.Add(panelTemp1);
            panelProperty.Controls.Add(panelTemp2);
            panelProperty.Controls.Add(panelTemp3);
            panelProperty.Controls.Add(panelTemp4);

            panelContent.Controls.Add(panelProperty);
            linkButtonCooker.Controls.Add(panelContent);
            linkButtonCooker.Controls.Add(DeviceBg());

            linkButtonCooker.Attributes.Add("data-device", (cooker as Device).TypeDevice());
            linkButtonCooker.Attributes.Add("data-id", cooker.Id.ToString());

            return linkButtonCooker;
        }


        // Microwave
        public static Control Microwave(Microwave microwave)
        {
            LinkButton linkButtonMicrowave = new LinkButton() { CssClass = "device-microwave" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelGrill = new Panel() { CssClass = "grill" };
            Panel panelWave = new Panel() { CssClass = "wave" };
            Label labelTextPower = new Label() { CssClass = "text" };
            Label labelTextValuePower = new Label() { CssClass = "text-value" };
            Label labelTextGrill = new Label() { CssClass = "text" };
            Label labelTextValueGrill = new Label() { CssClass = "text-value" };

            panelGrill.Attributes.CssStyle.Add("opacity", microwave.GrillPercent(microwave.Grill));
            panelWave.Attributes.CssStyle.Add("opacity", microwave.PowerPercent(microwave.Power));
            labelTextPower.Text = "POWER:";
            labelTextValuePower.Text = microwave.Power.ToString();
            labelTextGrill.Text = "GRILL:";
            labelTextValueGrill.Text = microwave.Grill.ToString();

            panelProperty.Controls.Add(panelGrill);
            panelProperty.Controls.Add(panelWave);
            panelProperty.Controls.Add(labelTextPower);
            panelProperty.Controls.Add(labelTextValuePower);
            panelProperty.Controls.Add(labelTextGrill);
            panelProperty.Controls.Add(labelTextValueGrill);

            panelContent.Controls.Add(panelProperty);
            linkButtonMicrowave.Controls.Add(panelContent);
            linkButtonMicrowave.Controls.Add(DeviceBg());

            linkButtonMicrowave.Attributes.Add("data-device", (microwave as Device).TypeDevice());
            linkButtonMicrowave.Attributes.Add("data-id", microwave.Id.ToString());

            return linkButtonMicrowave;
        }



        private static Control DeviceBg()
        {
            Panel panelBg = new Panel() { CssClass = "bg" };
            Panel panelBrTop = new Panel() { CssClass = "br-top" };
            Panel panelBrTopLeft = new Panel() { CssClass = "br-top-left" };
            Panel panelBottomLeft = new Panel() { CssClass = "br-bottom-left" };
            Panel panelBottomRight = new Panel() { CssClass = "br-bottom-right" };
            panelBg.Controls.Add(panelBrTop);
            panelBg.Controls.Add(panelBrTopLeft);
            panelBg.Controls.Add(panelBottomLeft);
            panelBg.Controls.Add(panelBottomRight);
            return panelBg;
        }

    }
}