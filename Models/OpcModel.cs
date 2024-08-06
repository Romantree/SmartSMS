using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carriage_SMS_Project.Models
{
    public class OpcModel
    {
        private string _FsID;
        private string _FsLine;
        private string _FsOP;
        private string _FsName;
        private string _FsType;
        private string _FsTagValue;
        private string _FsTagDesc;
        private string _FsQulity;
        private string _FsTCode;
        private string _FsFlag;


    
        //---------------------------------
        //---------------------------------
        public string ID
        {
            get { return _FsID; }
            set { _FsID = value;  }
        }
        //----------------------------------------------------------------------
        public string Line
        {
            get { return _FsLine; }
            set { _FsLine = value; }
        }
        //----------------------------------------------------------------------
        public string OP
        {
            get { return _FsOP; }
            set { _FsOP = value; }
        }
        //----------------------------------------------------------------------
        public string Name
        {
            get { return _FsName; }
            set { _FsName = value; }
        }
        //----------------------------------------------------------------------
        public string Type
        {
            get { return _FsType; }
            set { _FsType = value; }
        }
        //----------------------------------------------------------------------
        public string TagValue
        {
            get { return _FsTagValue; }
            set { _FsTagValue = value; }
        }
        //----------------------------------------------------------------------
        public string TagDesc
        {
            get { return _FsTagDesc; }
            set { _FsTagDesc = value; }
        }
        //----------------------------------------------------------------------
        public string Qulity
        {
            get { return _FsQulity; }
            set { _FsQulity = value; }
        }
        //----------------------------------------------------------------------
        public string TCode
        {
            get { return _FsTCode; }
            set { _FsTCode = value; }
        }
        //----------------------------------------------------------------------
        public string Flag
        {
            get { return _FsFlag; }
            set { _FsFlag = value; }
        }
        //----------------------------------------------------------------------
        public OpcModel()
        {
            // 생성자
            // 클래스 생성
            InitMembers();
        }
		//----------------------------------------------------------------------
        ~OpcModel()
        {
            // 소멸자
        }
        //----------------------------------------------------------------------
        private void InitMembers()
        {
            _FsID = "";
            _FsLine = "";
            _FsOP = "";
            _FsName = "";
            _FsType = "";
            _FsTagValue = "";
            _FsTagDesc = "";
            _FsQulity = "";
            _FsTCode = "";
            _FsFlag = "";
        }
        //----------------------------------------------------------------------
    }
    }
