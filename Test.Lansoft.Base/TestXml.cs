﻿/* -------------------------------------------------------------
	Archivo: TestXml.cs
	Modulo: Test.Lansoft.Base
	Autor: LAOS
	Actualizado: 2019/febrero/11
----------------------------------------------------------------*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml;

using Lansoft.Base;

namespace Test.Lansoft.Base
{
    [TestClass]
    public class TestXml
    {
        [TestMethod]
        public void Xml_NoDeclarationAndNoRootAttributes_str_noXml_throw_ex()
        {
            // Prepara
            string strXmlDocument = "<NOXML>";

            // Ejecuta y Comprueba
            try
            {
                string strXmlNormal = Xml.NoDeclarationAndNoRootAttributes(strXmlDocument);
                Assert.Fail();
            }
            catch (XmlException ex)
            {
                Assert.AreEqual("Excepcion en Xml.NoDeclarationAndNoRootAttributes(). El argumento xml no es un documento valido.", ex.Message);
            }
        }

        [TestMethod]
        public void Xml_NoDeclarationAndNoRootAttributes_str_NoXmlDecSiAtributos_ret_str()
        {
            // Prepara
            XmlDocument xDoc = new XmlDocument();
            xDoc.AppendChild(xDoc.CreateElement("Raiz"));
            xDoc.DocumentElement.Attributes.Append(xDoc.CreateAttribute("Atributo"));
            xDoc.DocumentElement.Attributes[0].InnerText = "Valor";

            // Ejecuta
            string strXmlNormal = Xml.NoDeclarationAndNoRootAttributes(xDoc.InnerXml);

            // Comprueba
            XmlDocument xDocNormal = new XmlDocument();
            xDocNormal.LoadXml(strXmlNormal);
            Assert.AreEqual(XmlNodeType.Element, xDoc.FirstChild.NodeType);
            Assert.AreEqual(1, xDoc.DocumentElement.Attributes.Count);
            Assert.AreEqual(XmlNodeType.Element, xDocNormal.FirstChild.NodeType);
            Assert.AreEqual(0, xDocNormal.DocumentElement.Attributes.Count);
        }

        [TestMethod]
        // [TestMethod]
        public void Xml_NoDeclarationAndNoRootAttributes_str_null_throw_ex()
        {
            // Prepara
            string strXmlDocument = null;


            // Ejecuta y Comprueba
            try
            {
                string strXmlNormal = Xml.NoDeclarationAndNoRootAttributes(strXmlDocument);
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Excepcion en Xml.NoDeclarationAndNoRootAttributes(). Argumento xml nulo.", ex.Message);
            }
        }

        [TestMethod]
        public void Xml_NoDeclarationAndNoRootAttributes_str_SiXmlDecNoAtributos_ret_str()
        {
            // Prepara
            XmlDocument xDoc = new XmlDocument();
            xDoc.AppendChild(xDoc.CreateXmlDeclaration("1.0", null, null));
            xDoc.AppendChild(xDoc.CreateElement("Raiz"));

            // Ejecuta
            string strXmlNormal = Xml.NoDeclarationAndNoRootAttributes(xDoc.InnerXml);

            // Comprueba
            XmlDocument xDocNormal = new XmlDocument();
            xDocNormal.LoadXml(strXmlNormal);
            Assert.AreEqual(XmlNodeType.XmlDeclaration, xDoc.FirstChild.NodeType);
            Assert.AreEqual(0, xDoc.DocumentElement.Attributes.Count);
            Assert.AreEqual(XmlNodeType.Element, xDocNormal.DocumentElement.NodeType);
            Assert.AreEqual(0, xDocNormal.DocumentElement.Attributes.Count);
        }

        [TestMethod]
        public void Xml_NoDeclarationAndNoRootAttributes_str_SiXmlDecSiAtributos_ret_str()
        {
            // Prepara
            XmlDocument xDoc = new XmlDocument();
            xDoc.AppendChild(xDoc.CreateXmlDeclaration("1.0", null, null));
            xDoc.AppendChild(xDoc.CreateElement("Raiz"));
            xDoc.DocumentElement.Attributes.Append(xDoc.CreateAttribute("Atributo"));
            xDoc.DocumentElement.Attributes[0].InnerText = "Valor";

            // Ejecuta
            string strXmlNormal = Xml.NoDeclarationAndNoRootAttributes(xDoc.InnerXml);

            // Comprueba
            XmlDocument xDocNormal = new XmlDocument();
            xDocNormal.LoadXml(strXmlNormal);
            Assert.AreEqual(XmlNodeType.XmlDeclaration, xDoc.FirstChild.NodeType);
            Assert.AreEqual(XmlNodeType.Element, xDoc.DocumentElement.NodeType);
            Assert.AreEqual(1, xDoc.DocumentElement.Attributes.Count);
            Assert.AreEqual(XmlNodeType.Element, xDocNormal.FirstChild.NodeType);
            Assert.AreEqual(0, xDocNormal.DocumentElement.Attributes.Count);
        }
    }
}
