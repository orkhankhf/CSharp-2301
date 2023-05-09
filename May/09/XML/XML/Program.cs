using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write XML
            XmlTextWriter xmlText = new XmlTextWriter(@"C:\\XML\\Customers.xml", UTF8Encoding.UTF8);

            xmlText.WriteComment("Müştəri məlumatları"); //Comment yazır

            xmlText.WriteStartElement("Customers"); //Customers node'unu açır

                xmlText.WriteStartElement("Customer"); //Customer node'unu açır
                xmlText.WriteAttributeString("Id", "1");
                    xmlText.WriteElementString("Name", "Orkhan");
                    xmlText.WriteElementString("Surname", "Farajov");
                    xmlText.WriteElementString("Job", "Programmer");
                    xmlText.WriteElementString("Country", "Azerbaijan");
                xmlText.WriteEndElement(); //Customers node'unu bağlayır

                xmlText.WriteStartElement("Customer"); //Customer node'unu açır
                    xmlText.WriteAttributeString("Id", "2");
                    xmlText.WriteElementString("Name", "Nihad");
                    xmlText.WriteElementString("Surname", "Asadov");
                    xmlText.WriteElementString("Job", "Doctor");
                    xmlText.WriteElementString("Country", "Turkey");
                xmlText.WriteEndElement(); //Customers node'unu bağlayır

            xmlText.WriteEndElement(); //Customers node'unu bağlayır

            xmlText.Close(); //Faylı bağlayır
            #endregion

            #region Read XML
            XmlReader xRead = XmlReader.Create(@"C:\\XML\\Customers.xml");
            while (xRead.Read())
            {
                Console.WriteLine($"{xRead.Name}: {xRead.Value}");
            }
            xRead.Close();
            #endregion



            #region LINQ to XML

            #region Create Document with XDocument
            /*
                1. Xdocument
                2. Xdeclaretion
                3. Xcomment
                4. Xelement
                5. Xattribute    
             */

            /*
                <?xml version="1.0" encoding="utf-8" ?>

                <!-- Müştəri məlumatları -->
                <Customers>
                  <Customer Id="1">
                    <Name>Orkhan</Name>
                    <Surname>Farajov</Surname>
                    <Job>Programmer</Job>
                    <Country>Azerbaijan</Country>
                  </Customer>
                </Customers>
             */

            XDocument Xdocument = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"), //<?xml version="1.0" encoding="utf-8" ?>
                new XComment("Müştəri məlumatları"), //<!-- Müştəri məlumatları -->
                new XElement("Customers", //<Customers>
                    new XElement("Customer", //<Customer>
                        new XAttribute("Id", "1"), // Id="1"
                        new XElement("Name", "Orkhan"), //<Name>Orkhan</Name>
                        new XElement("Surname", "Farajov"), //<Surname>Farajov</Surname>
                        new XElement("Job", "Programmer"), //<Job>Programmer</Job>
                        new XElement("Country", "Azerbaijan") //<Country>Azerbaijan</Country>
                    )
                )
            );
            Xdocument.Save(@"C:\\XML\\Customers.xml");


            var xDeclaration = new XDeclaration("1.0", "UTF-8", "yes");

            var customerNode = new XElement("Customer", //<Customer>
                                    new XAttribute("Id", "1"), // Id="1"
                                    new XElement("Name", "Orkhan"), //<Name>Orkhan</Name>
                                    new XElement("Surname", "Farajov"), //<Surname>Farajov</Surname>
                                    new XElement("Job", "Programmer"), //<Job>Programmer</Job>
                                    new XElement("Country", "Azerbaijan") //<Country>Azerbaijan</Country>
                                );

            XDocument basic = new XDocument(
                xDeclaration,
                new XComment("Müştəri məlumatları"), //<!-- Müştəri məlumatları -->
                new XElement("Customers", //<Customers>
                    customerNode
                )
            );

            basic.Save(@"C:\\XML\\Customers.xml");

            #endregion
            #endregion
        }
    }
}
