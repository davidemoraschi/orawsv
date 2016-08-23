#if _DYNAMIC_XMLSERIALIZER_COMPILATION
[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
#endif
[assembly:System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"3d351f6e-c5b5-469b-8fab-736e36acbe45,", Version=@"2.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write7_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS004_EPISODIO_POR_NEPISInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write8_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write9_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS003_EPISODIOS_POR_NDNIInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write10_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write11_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS002_EPISODIOS_POR_NHISTInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write12_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write13_WS001_EPISODIOS_POR_NUHSAInput(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"WS001_EPISODIOS_POR_NUHSAInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                Write6_Item(@"P_RESULTADO-XMLTYPE-OUT", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ((global::PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT)p[0]), false, false);
            }
            if (pLength > 1) {
                WriteElementString(@"P_NUHSA-VARCHAR2-IN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ((global::System.String)p[1]));
            }
            WriteEndElement();
        }

        public void Write14_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write15_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS004_EPISODIO_POR_NEPISInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write16_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write17_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS003_EPISODIOS_POR_NDNIInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write18_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write19_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS002_EPISODIOS_POR_NHISTInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write20_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write21_WS001_EPISODIOS_POR_NUHSAInput(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"WS001_EPISODIOS_POR_NUHSAInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                Write2_Item(@"P_RESULTADO-XMLTYPE-OUT", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ((global::PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT)p[0]), false, false);
            }
            if (pLength > 1) {
                WriteElementString(@"P_NUHSA-VARCHAR2-IN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ((global::System.String)p[1]));
            }
            WriteEndElement();
        }

        public void Write22_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write23_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS004_EPISODIO_POR_NEPISInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write24_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write25_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS003_EPISODIOS_POR_NDNIInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write26_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write27_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"S-WS002_EPISODIOS_POR_NHISTInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                if ((((global::System.Xml.XmlElement)p[0])) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)p[0]) == null) {
                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)p[0]), @"RETURN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", false, false);
                }
                else {
                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)p[0]));
                }
            }
            WriteEndElement();
        }

        public void Write28_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        public void Write29_WS001_EPISODIOS_POR_NUHSAInput(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"WS001_EPISODIOS_POR_NUHSAInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", null, false);
            if (pLength > 0) {
                Write4_Item(@"P_RESULTADO-XMLTYPE-OUT", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ((global::PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT)p[0]), false, false);
            }
            if (pLength > 1) {
                WriteElementString(@"P_NUHSA-VARCHAR2-IN", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD", ((global::System.String)p[1]));
            }
            WriteEndElement();
        }

        public void Write30_Item(object[] p) {
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
        }

        void Write4_Item(string n, string ns, global::PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
            WriteEndElement(o);
        }

        void Write2_Item(string n, string ns, global::PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
            WriteEndElement(o);
        }

        void Write6_Item(string n, string ns, global::PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object[] Read7_WS004_EPISODIO_POR_NEPISOutput() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id1_WS004_EPISODIO_POR_NEPISOutput, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations1 = 0;
                    int readerCount1 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations1, ref readerCount1);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS004_EPISODIO_POR_NEPISOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            return p;
        }

        public object[] Read8_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            return p;
        }

        public object[] Read9_WS003_EPISODIOS_POR_NDNIOutput() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id3_WS003_EPISODIOS_POR_NDNIOutput, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations4 = 0;
                    int readerCount4 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations4, ref readerCount4);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS003_EPISODIOS_POR_NDNIOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            return p;
        }

        public object[] Read10_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations5, ref readerCount5);
            }
            return p;
        }

        public object[] Read11_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id4_Item, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations7 = 0;
                    int readerCount7 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations7, ref readerCount7);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS002_EPISODIOS_POR_NHISTOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            return p;
        }

        public object[] Read12_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations8, ref readerCount8);
            }
            return p;
        }

        public object[] Read13_Item() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations9 = 0;
            int readerCount9 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id5_Item, id2_Item)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations10 = 0;
                    int readerCount10 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id6_P_RESULTADO && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                p[0] = (global::System.Xml.XmlElement)ReadXmlNode(true);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:P_RESULTADO");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:P_RESULTADO");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations10, ref readerCount10);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS001_EPISODIOS_POR_NUHSAOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations9, ref readerCount9);
            }
            return p;
        }

        public object[] Read14_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations11 = 0;
            int readerCount11 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations11, ref readerCount11);
            }
            return p;
        }

        public object[] Read15_WS004_EPISODIO_POR_NEPISOutput() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations12 = 0;
            int readerCount12 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id1_WS004_EPISODIO_POR_NEPISOutput, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations13 = 0;
                    int readerCount13 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations13, ref readerCount13);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS004_EPISODIO_POR_NEPISOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations12, ref readerCount12);
            }
            return p;
        }

        public object[] Read16_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations14 = 0;
            int readerCount14 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations14, ref readerCount14);
            }
            return p;
        }

        public object[] Read17_WS003_EPISODIOS_POR_NDNIOutput() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations15 = 0;
            int readerCount15 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id3_WS003_EPISODIOS_POR_NDNIOutput, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations16 = 0;
                    int readerCount16 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations16, ref readerCount16);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS003_EPISODIOS_POR_NDNIOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations15, ref readerCount15);
            }
            return p;
        }

        public object[] Read18_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations17 = 0;
            int readerCount17 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations17, ref readerCount17);
            }
            return p;
        }

        public object[] Read19_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations18 = 0;
            int readerCount18 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id4_Item, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations19 = 0;
                    int readerCount19 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations19, ref readerCount19);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS002_EPISODIOS_POR_NHISTOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations18, ref readerCount18);
            }
            return p;
        }

        public object[] Read20_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations20 = 0;
            int readerCount20 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations20, ref readerCount20);
            }
            return p;
        }

        public object[] Read21_Item() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations21 = 0;
            int readerCount21 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id5_Item, id2_Item)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations22 = 0;
                    int readerCount22 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id6_P_RESULTADO && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                p[0] = (global::System.Xml.XmlElement)ReadXmlNode(true);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:P_RESULTADO");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:P_RESULTADO");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations22, ref readerCount22);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS001_EPISODIOS_POR_NUHSAOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations21, ref readerCount21);
            }
            return p;
        }

        public object[] Read22_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations23 = 0;
            int readerCount23 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations23, ref readerCount23);
            }
            return p;
        }

        public object[] Read23_WS004_EPISODIO_POR_NEPISOutput() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations24 = 0;
            int readerCount24 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id1_WS004_EPISODIO_POR_NEPISOutput, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations25 = 0;
                    int readerCount25 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations25, ref readerCount25);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS004_EPISODIO_POR_NEPISOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations24, ref readerCount24);
            }
            return p;
        }

        public object[] Read24_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations26 = 0;
            int readerCount26 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations26, ref readerCount26);
            }
            return p;
        }

        public object[] Read25_WS003_EPISODIOS_POR_NDNIOutput() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations27 = 0;
            int readerCount27 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id3_WS003_EPISODIOS_POR_NDNIOutput, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations28 = 0;
                    int readerCount28 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations28, ref readerCount28);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS003_EPISODIOS_POR_NDNIOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations27, ref readerCount27);
            }
            return p;
        }

        public object[] Read26_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations29 = 0;
            int readerCount29 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations29, ref readerCount29);
            }
            return p;
        }

        public object[] Read27_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations30 = 0;
            int readerCount30 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id4_Item, id2_Item)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations31 = 0;
                    int readerCount31 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations31, ref readerCount31);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS002_EPISODIOS_POR_NHISTOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations30, ref readerCount30);
            }
            return p;
        }

        public object[] Read28_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations32 = 0;
            int readerCount32 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations32, ref readerCount32);
            }
            return p;
        }

        public object[] Read29_Item() {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations33 = 0;
            int readerCount33 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id5_Item, id2_Item)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations34 = 0;
                    int readerCount34 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id6_P_RESULTADO && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                p[0] = (global::System.Xml.XmlElement)ReadXmlNode(true);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:P_RESULTADO");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:P_RESULTADO");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations34, ref readerCount34);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD:WS001_EPISODIOS_POR_NUHSAOutput");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations33, ref readerCount33);
            }
            return p;
        }

        public object[] Read30_Item() {
            Reader.MoveToContent();
            object[] p = new object[0];
            bool[] paramsRead = new bool[0];
            Reader.MoveToContent();
            int whileIterations35 = 0;
            int readerCount35 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)p, @"");
                }
                else {
                    UnknownNode((object)p, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations35, ref readerCount35);
            }
            return p;
        }

        protected override void InitCallbacks() {
        }

        string id6_P_RESULTADO;
        string id2_Item;
        string id3_WS003_EPISODIOS_POR_NDNIOutput;
        string id1_WS004_EPISODIO_POR_NEPISOutput;
        string id4_Item;
        string id5_Item;

        protected override void InitIDs() {
            id6_P_RESULTADO = Reader.NameTable.Add(@"P_RESULTADO");
            id2_Item = Reader.NameTable.Add(@"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
            id3_WS003_EPISODIOS_POR_NDNIOutput = Reader.NameTable.Add(@"WS003_EPISODIOS_POR_NDNIOutput");
            id1_WS004_EPISODIO_POR_NEPISOutput = Reader.NameTable.Add(@"WS004_EPISODIO_POR_NEPISOutput");
            id4_Item = Reader.NameTable.Add(@"WS002_EPISODIOS_POR_NHISTOutput");
            id5_Item = Reader.NameTable.Add(@"WS001_EPISODIOS_POR_NUHSAOutput");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    public sealed class ArrayOfObjectSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS004_EPISODIO_POR_NEPISInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write7_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer1 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS004_EPISODIO_POR_NEPISOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read7_WS004_EPISODIO_POR_NEPISOutput();
        }
    }

    public sealed class ArrayOfObjectSerializer2 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS004_EPISODIO_POR_NEPISInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write8_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer3 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS004_EPISODIO_POR_NEPISOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read8_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer4 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS003_EPISODIOS_POR_NDNIInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write9_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer5 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS003_EPISODIOS_POR_NDNIOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read9_WS003_EPISODIOS_POR_NDNIOutput();
        }
    }

    public sealed class ArrayOfObjectSerializer6 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS003_EPISODIOS_POR_NDNIInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write10_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer7 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS003_EPISODIOS_POR_NDNIOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read10_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer8 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS002_EPISODIOS_POR_NHISTInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write11_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer9 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS002_EPISODIOS_POR_NHISTOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read11_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer10 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS002_EPISODIOS_POR_NHISTInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write12_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer11 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS002_EPISODIOS_POR_NHISTOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read12_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer12 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write13_WS001_EPISODIOS_POR_NUHSAInput((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer13 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read13_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer14 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write14_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer15 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read14_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer16 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS004_EPISODIO_POR_NEPISInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write23_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer17 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS004_EPISODIO_POR_NEPISOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read23_WS004_EPISODIO_POR_NEPISOutput();
        }
    }

    public sealed class ArrayOfObjectSerializer18 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS004_EPISODIO_POR_NEPISInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write24_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer19 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS004_EPISODIO_POR_NEPISOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read24_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer20 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS003_EPISODIOS_POR_NDNIInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write25_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer21 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS003_EPISODIOS_POR_NDNIOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read25_WS003_EPISODIOS_POR_NDNIOutput();
        }
    }

    public sealed class ArrayOfObjectSerializer22 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS003_EPISODIOS_POR_NDNIInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write26_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer23 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS003_EPISODIOS_POR_NDNIOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read26_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer24 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS002_EPISODIOS_POR_NHISTInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write27_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer25 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS002_EPISODIOS_POR_NHISTOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read27_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer26 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"S-WS002_EPISODIOS_POR_NHISTInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write28_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer27 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS002_EPISODIOS_POR_NHISTOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read28_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer28 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAInput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write29_WS001_EPISODIOS_POR_NUHSAInput((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer29 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAOutput", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read29_Item();
        }
    }

    public sealed class ArrayOfObjectSerializer30 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAInputInHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write30_Item((object[])objectToSerialize);
        }
    }

    public sealed class ArrayOfObjectSerializer31 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"WS001_EPISODIOS_POR_NUHSAOutputOutHeaders", @"http://xmlns.oracle.com/orawsv/WS_RO/PKG_WS_CMBD");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read30_Item();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):Response"] = @"Read7_WS004_EPISODIO_POR_NEPISOutput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):OutHeaders"] = @"Read8_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):Response"] = @"Read9_WS003_EPISODIOS_POR_NDNIOutput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):OutHeaders"] = @"Read10_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):Response"] = @"Read11_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):OutHeaders"] = @"Read12_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):Response"] = @"Read13_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):OutHeaders"] = @"Read14_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):Response"] = @"Read15_WS004_EPISODIO_POR_NEPISOutput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):OutHeaders"] = @"Read16_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):Response"] = @"Read17_WS003_EPISODIOS_POR_NDNIOutput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):OutHeaders"] = @"Read18_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):Response"] = @"Read19_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):OutHeaders"] = @"Read20_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):Response"] = @"Read21_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):OutHeaders"] = @"Read22_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):Response"] = @"Read23_WS004_EPISODIO_POR_NEPISOutput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):OutHeaders"] = @"Read24_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):Response"] = @"Read25_WS003_EPISODIOS_POR_NDNIOutput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):OutHeaders"] = @"Read26_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):Response"] = @"Read27_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):OutHeaders"] = @"Read28_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):Response"] = @"Read29_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):OutHeaders"] = @"Read30_Item";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement)"] = @"Write7_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):InHeaders"] = @"Write8_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement)"] = @"Write9_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):InHeaders"] = @"Write10_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement)"] = @"Write11_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):InHeaders"] = @"Write12_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String)"] = @"Write13_WS001_EPISODIOS_POR_NUHSAInput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):InHeaders"] = @"Write14_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement)"] = @"Write15_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):InHeaders"] = @"Write16_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement)"] = @"Write17_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):InHeaders"] = @"Write18_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement)"] = @"Write19_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):InHeaders"] = @"Write20_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String)"] = @"Write21_WS001_EPISODIOS_POR_NUHSAInput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):InHeaders"] = @"Write22_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement)"] = @"Write23_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):InHeaders"] = @"Write24_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement)"] = @"Write25_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):InHeaders"] = @"Write26_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement)"] = @"Write27_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):InHeaders"] = @"Write28_Item";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String)"] = @"Write29_WS001_EPISODIOS_POR_NUHSAInput";
                    _tmp[@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):InHeaders"] = @"Write30_Item";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):OutHeaders", new ArrayOfObjectSerializer23());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):OutHeaders", new ArrayOfObjectSerializer19());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):Response", new ArrayOfObjectSerializer29());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):InHeaders", new ArrayOfObjectSerializer14());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):Response", new ArrayOfObjectSerializer9());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):Response", new ArrayOfObjectSerializer5());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement)", new ArrayOfObjectSerializer8());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):InHeaders", new ArrayOfObjectSerializer26());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):OutHeaders", new ArrayOfObjectSerializer7());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):OutHeaders", new ArrayOfObjectSerializer15());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):Response", new ArrayOfObjectSerializer1());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):InHeaders", new ArrayOfObjectSerializer6());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String)", new ArrayOfObjectSerializer28());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement)", new ArrayOfObjectSerializer20());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):Response", new ArrayOfObjectSerializer21());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement)", new ArrayOfObjectSerializer24());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):Response", new ArrayOfObjectSerializer17());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):InHeaders", new ArrayOfObjectSerializer2());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):OutHeaders", new ArrayOfObjectSerializer3());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):InHeaders", new ArrayOfObjectSerializer30());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_DESA.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):OutHeaders", new ArrayOfObjectSerializer31());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):Response", new ArrayOfObjectSerializer25());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement)", new ArrayOfObjectSerializer4());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String)", new ArrayOfObjectSerializer12());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):OutHeaders", new ArrayOfObjectSerializer11());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):InHeaders", new ArrayOfObjectSerializer10());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS003_EPISODIOS_POR_NDNI(System.Xml.XmlElement):InHeaders", new ArrayOfObjectSerializer22());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:System.Xml.XmlElement WS001_EPISODIOS_POR_NUHSA(PKG_WS_CMBD.PKG_WS_CMBD_PROD.WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT, System.String):Response", new ArrayOfObjectSerializer13());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement):InHeaders", new ArrayOfObjectSerializer18());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement)", new ArrayOfObjectSerializer16());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService:Void WS002_EPISODIOS_POR_NHIST(System.Xml.XmlElement):OutHeaders", new ArrayOfObjectSerializer27());
                    _tmp.Add(@"PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService:Void WS004_EPISODIO_POR_NEPIS(System.Xml.XmlElement)", new ArrayOfObjectSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::PKG_WS_CMBD.PKG_WS_CMBD_PROD.PKG_WS_CMBDService)) return true;
            if (type == typeof(global::PKG_WS_CMBD.PKG_WS_CMBD_NOKeepAlive)) return true;
            if (type == typeof(global::PKG_WS_CMBD.PKG_WS_CMBD_DESA.PKG_WS_CMBDService)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            return null;
        }
    }
}
