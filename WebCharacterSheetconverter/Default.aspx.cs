using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;

namespace WebCharacterSheetconverter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var uploadedFile = Request.Files[0];

            System.IO.Stream test = uploadedFile.InputStream;

            var doc = new HtmlDocument();

            doc.Load(test);

            #region Read Fields to TextBox

            if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[1]/div[1]/input") != null)
            {
                //AC
                replaceMe.Text = doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[1]/div[1]/input").GetAttributeValue("value", "") + "|";
                //Acrobatics
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[1]/input[2]").GetAttributeValue("value", "") + "|";
                //Age
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[2]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //Alignment
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[2]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Allies
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[4]/div[1]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";
                //Animal
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //Arcana
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Athletics
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //AttacksSpellcasting
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[6]/div").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";
                //Background
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[2]/div[1]/input[2]").GetAttributeValue("value", "") + "|";
                //Backstory
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[3]/div[2]/div[1]/div").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";
                //Bonds
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[5]/div[1]/div[3]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";
                //CHA
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[6]/div[2]/input").GetAttributeValue("value", "") + "|";
                //CHAmod
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[6]/div[3]/input").GetAttributeValue("value", "") + "|";
                //CON
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[3]/div[2]/input").GetAttributeValue("value", "") + "|";
                //CONmod
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[3]/div[3]/input").GetAttributeValue("value", "") + "|";
                //CP
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[3]/div[1]/div[1]/input").GetAttributeValue("value", "") + "|";
                //CharacterName
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[1]/div[1]/input").GetAttributeValue("value", "") + "|";
                //CharacterName2
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[1]/div[1]/input").GetAttributeValue("value", "") + "|";
                #endregion
                #region Checkboxes

                //CB11
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[1]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB12
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[2]/div[1]/span/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB13
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[2]/div[1]/span/input[2]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB14
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[2]/div[1]/span/input[3]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB15
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[2]/div[2]/span/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB16
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[2]/div[2]/span/input[2]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB17
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[2]/div[2]/span/input[3]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB18
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB19
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB20
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB21
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB22
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB23
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[1]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB24
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB25
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB251
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB26
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB27
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB28
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB29
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB30
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";


                //CB3010
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3011
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3012
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3013
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3014
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[9]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3015
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[10]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3016
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[11]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3017
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[12]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3018
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[13]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3019
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[14]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB3020
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3021
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3022
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3023
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3024
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3025
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[9]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3026
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[10]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3027
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[11]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3028
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[12]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3029
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[13]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3030
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[14]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB3031
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3032
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3033
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3034
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3035
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3036
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[9]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3037
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[10]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3038
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[11]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3039
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[12]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3040
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[13]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3041
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[14]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB3042
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3043
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3044
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3045
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3046
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3047
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[9]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3048
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[10]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3049
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[11]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3050
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[12]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3051
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[13]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3052
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[14]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB3053
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3054
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3055
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3056
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3057
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3058
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[9]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3059
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[10]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB3060
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3061
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3062
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3063
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3064
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3065
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[9]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3066
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[10]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB3067
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3068
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3069
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3070
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3071
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3072
                replaceMe.Text = replaceMe.Text + "Off|";
                //CB3073
                replaceMe.Text = replaceMe.Text + "Off|";



                //CB3074
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3075
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3076
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3077
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3078
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";




                //CB3079
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3080
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[5]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3081
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[6]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3082
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[7]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB3083
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[8]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB309
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[4]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB31
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[9]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB310
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB313
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";

                //CB314
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB315
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";

                //CB316
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB317
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";

                //CB318
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB319
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB32
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[10]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB320
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB321
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";

                //CB322
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB323
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";

                //CB324
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB325
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";

                //CB326
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[3]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB327
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[2]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";



                //CB33
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[11]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB34
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[12]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB35
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[13]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB36
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[14]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB37
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[15]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB38
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[16]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB39
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[17]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";
                //CB40
                if (doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[18]/input[1]").GetAttributeValue("checked", "") == "checked") replaceMe.Text = replaceMe.Text + "Yes" + "|"; else replaceMe.Text = replaceMe.Text + "Off" + "|";

                #endregion
                #region Read Fields to TextBox cont
                //ClassLevel
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[2]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //DEX
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[2]/div[2]/input").GetAttributeValue("value", "") + "|";
                //DEXmod
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[2]/div[3]/input").GetAttributeValue("value", "") + "|";
                //Deception
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //EP
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[3]/div[1]/div[3]/input").GetAttributeValue("value", "") + "|";



                //Equipment
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[3]/div[2]/div").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";


                //Eyes
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[2]/div[3]/input[1]").GetAttributeValue("value", "") + "|";



                //Faction Name
                replaceMe.Text = replaceMe.Text + "|";


                //Feat + Trait
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[4]/div[2]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";
                //Features and Traits
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[5]/div[2]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";
                //Flaws
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[5]/div[1]/div[4]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";



                //GP
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[3]/div[1]/div[4]/input").GetAttributeValue("value", "") + "|";
                //HD
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/input").GetAttributeValue("value", "") + "|";
                //HDTotal
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/input").GetAttributeValue("value", "") + "|";
                //HPCurrent
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[2]/div[2]/input").GetAttributeValue("value", "") + "|";
                //HPMax
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[2]/div[1]/input").GetAttributeValue("value", "") + "|";
                //HPTemp
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[3]/div[1]/input").GetAttributeValue("value", "") + "|";
                //HAIR
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[2]/div[3]/input[3]").GetAttributeValue("value", "") + "|";
                //Height
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[2]/div[1]/input[2]").GetAttributeValue("value", "") + "|";
                //history
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //int
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[4]/div[2]/input").GetAttributeValue("value", "") + "|";
                //intmod
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[4]/div[3]/input").GetAttributeValue("value", "") + "|";



                //ideals
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[5]/div[1]/div[2]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";



                //initiative
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[1]/div[2]/input").GetAttributeValue("value", "") + "|";
                //insight
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //inspiration
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[1]/div/input").GetAttributeValue("value", "") + "|";
                //intimidation
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //investigation
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[9]/input[2]").GetAttributeValue("value", "") + "|";
                //medicine
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[10]/input[2]").GetAttributeValue("value", "") + "|";
                //nature
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[11]/input[2]").GetAttributeValue("value", "") + "|";
                //pp
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[3]/div[1]/div[5]/input").GetAttributeValue("value", "") + "|";
                //passive
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[3]/div/input").GetAttributeValue("value", "") + "|";
                //perception
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[12]/input[2]").GetAttributeValue("value", "") + "|";
                //performance
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[13]/input[2]").GetAttributeValue("value", "") + "|";



                //personality traits
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[5]/div[1]/div[1]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";



                //persuassion
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[14]/input[2]").GetAttributeValue("value", "") + "|";
                //playername
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[2]/div[1]/input[3]").GetAttributeValue("value", "") + "|";
                //profbonus
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[2]/div/input").GetAttributeValue("value", "") + "|";



                //proficienciesLanguages
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[4]/div[1]/div").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";



                //Race
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[2]/div[3]/input[1]").GetAttributeValue("value", "") + "|";
                //Religion
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[15]/input[2]").GetAttributeValue("value", "") + "|";
                //SP
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[3]/div[1]/div[2]/input").GetAttributeValue("value", "") + "|";
                //ST Charisma
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //ST Constitution
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //ST Dexterity
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //ST Intelligence
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //ST Strength
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[1]/input[2]").GetAttributeValue("value", "") + "|";
                //ST Wisdom
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[3]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //STR
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[1]/div[2]/input").GetAttributeValue("value", "") + "|";
                //STRmod
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[1]/div[3]/input").GetAttributeValue("value", "") + "|";
                //Skin
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[2]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //SlightofHand
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[16]/input[2]").GetAttributeValue("value", "") + "|";
                //SlotsRemaining19
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining20
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining21
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining22
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining23
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining24
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining25
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining26
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsRemaining27
                replaceMe.Text = replaceMe.Text + "|";
                //SlotsTotal19
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[2]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal20
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal21
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal22
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal23
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal24
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal25
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal26
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //SlotsTotal27
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                //Speed
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[1]/div[1]/div[3]/input").GetAttributeValue("value", "") + "|";
                //SpellATKBonus2
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[2]/div[1]/input[3]").GetAttributeValue("value", "") + "|";
                //SpellSaveDC2
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[2]/div[1]/input[2]").GetAttributeValue("value", "") + "|";
                //Spellcasting Class 2
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[1]/div[1]/input").GetAttributeValue("value", "") + "|";
                //Spellcasting Ability
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[2]/div[1]/input[1]").GetAttributeValue("value", "") + "|";
                #endregion
                #region Spells
                //Spells10100
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells10101
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[2]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells101010
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells101011
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells101012
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells101013
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[8]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells10102
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells10103
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells10104
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells10105
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells10106
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[3]/div[8]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells10107
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells10108
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[2]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells10109
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[4]/div[4]/input[2]").GetAttributeValue("value", "") + "|";


                //Spells1014
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[2]/input").GetAttributeValue("value", "") + "|";



                //Spells1015
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[3]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1016
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[3]/input").GetAttributeValue("value", "") + "|";
                //Spells1017
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[4]/input").GetAttributeValue("value", "") + "|";
                //Spells1018
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[5]/input").GetAttributeValue("value", "") + "|";
                //Spells1019
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[6]/input").GetAttributeValue("value", "") + "|";
                //Spells1020
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[7]/input").GetAttributeValue("value", "") + "|";
                //Spells1021
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[8]/input").GetAttributeValue("value", "") + "|";
                //Spells1022
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[1]/div[9]/input").GetAttributeValue("value", "") + "|";



                //Spells1023
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1024
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1025
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1026
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1027
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1028
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[9]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1029
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[10]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1030
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[11]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1031
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[12]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1032
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[13]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1033
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[2]/div[14]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1034
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1035
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1036
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1037
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1038
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1039
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1040
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[9]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1041
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[10]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1042
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[11]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1043
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[12]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1044
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[13]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1045
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[14]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1046
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[3]/div[3]/div[2]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1047
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1048
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1049
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1050
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1051
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1052
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1053
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1054
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[9]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1055
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[10]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1056
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[11]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1057
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[12]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1058
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[13]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1059
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[1]/div[14]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1060
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1061
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1062
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1063
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1064
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1065
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1066
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1067
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[9]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1068
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[10]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1069
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[11]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1070
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[12]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1071
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[13]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1072
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[2]/div[14]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1073
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1074
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1075
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1076
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1077
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1078
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1079
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1080
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[9]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1081
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[4]/div[3]/div[10]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1082
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1083
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1084
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1085
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1086
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1087
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1088
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1089
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[9]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1090
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[1]/div[10]/input[2]").GetAttributeValue("value", "") + "|";



                //Spells1091
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1092
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1093
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1094
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[5]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1095
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[6]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1096
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[7]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1097
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[3]/div[5]/div[2]/div[8]/input[2]").GetAttributeValue("value", "") + "|";
                //Spells1098
                replaceMe.Text = replaceMe.Text + "|";
                //Spells1099
                replaceMe.Text = replaceMe.Text + "|";
                #endregion
                #region Read Fields to TextBox Cont
                //Stealth
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[17]/input[2]").GetAttributeValue("value", "") + "|";
                //Survival
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[2]/div[4]/div[18]/input[2]").GetAttributeValue("value", "") + "|";


                //Treasure

                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[4]/div[3]/div[1]").InnerHtml.Replace("\r\n", "").Replace("</div>", "[nl]").Replace("<div>", "").Replace("<br>", "").Replace("&nbsp;", " ") + "|";

                //WIS
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[5]/div[2]/input").GetAttributeValue("value", "") + "|";
                //Wismod
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[3]/div[1]/div[5]/div[3]/input").GetAttributeValue("value", "") + "|";
                //Weight
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div[2]/div[1]/input[3]").GetAttributeValue("value", "") + "|";
                //Wpn Name
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[2]/input[1]").GetAttributeValue("value", "") + "|";
                //Wpn Name2
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[3]/input[1]").GetAttributeValue("value", "") + "|";
                //wpn Name3
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[4]/input[1]").GetAttributeValue("value", "") + "|";
                //Wpn atk bonus
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[2]/input[2]").GetAttributeValue("value", "") + "|";
                //wpn damage
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[2]/input[3]").GetAttributeValue("value", "") + "|";
                //Wpn atk bonus2\
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[3]/input[2]").GetAttributeValue("value", "") + "|";
                //wpn damage2
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[3]/input[3]").GetAttributeValue("value", "") + "|";
                //wpn atk bonus3
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[4]/input[2]").GetAttributeValue("value", "") + "|";
                //Wpn Damage3
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[4]/div[2]/div[4]/input[3]").GetAttributeValue("value", "") + "|";
                //XP
                replaceMe.Text = replaceMe.Text + doc.DocumentNode.SelectSingleNode("/html/body/div/div[1]/div[2]/div[3]/input[3]").GetAttributeValue("value", "") + "|";
                #endregion

            }
            else
            {
                replaceMe.Text = "Error Parsing File";
            }
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.ContentType = "text/HTML";
            Response.AppendHeader("Content-Disposition", "attachment; filename=CharacterSheet.html");
            Response.TransmitFile(Server.MapPath("~/Content/Character Sheet.html"));
            Response.End();

        }
    }
}