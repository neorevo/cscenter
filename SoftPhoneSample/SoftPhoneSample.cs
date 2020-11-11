using System;
using System.Windows.Forms;
using AxICAPILib;

namespace SoftPhoneSample
{
    public partial class SoftPhoneSample : Form
    {
        private int _globalHandle;
        private string _agentDn;
        private string _agentId;
        private string _thisDn;
        private string _connectionId;

        private int _monitorid;

        public SoftPhoneSample()
        {
            InitializeComponent();
            InitializeICAPI();
        }

        private void InitializeICAPI()
        {
            iCapi.ICSetLogPath(
                2,
                "C:/Project/Logs/SoftPhoneSample",
                "ICAPILogs.log"
            );

            //if(g_ipAddr == "127.0.0.1"){
            //     g_ipAddr = "52.90.207.54";
            // }

            // V_CTI_RESULT = ICAPI_CTI.ICOpenServerExCv(
            //   ""//ds_ctiData.getColumn(0,"SERVER_NM")
            // , ""//ds_ctiData.getColumn(0,"SERVER_PW")
            // , g_ipAddr
            // , ds_ctiData.getColumn(0,"SERVER_IP1")
            // , ds_ctiData.getColumn(0,"SERVER_IP2")
            // , toNumber(ds_ctiData.getColumn(0,"PORT"))
            // , toNumber(ds_ctiData.getColumn(0,"TIMEOUT"))
            // , -1
            // , "EUC-KR"
            // );

            var openResult = iCapi.ICOpenServer(
                "FoodVille",
                "",
                "10.185.191.157", // TODO 상담실에서 확인 필요, 내 아이피!
                "10.121.111.52",
                "10.121.111.53",
                9202,
                10000,
                -1
            );

            if (openResult <= 0)
            {
                lbl_LogLabel.Text = "ooo ooo ooo Error!! Error Code : " + openResult;
            }

            _globalHandle = openResult;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userId = txt_UserId.Text;
            var userPw = txt_UserPw.Text;
            var agentDn = txt_AgentDn.Text;

            var log = "ooo ooo ooo UserID : " + userId;
            log += "\nooo ooo ooo UserPW : " + userPw;
            lbl_LogLabel.Text = log;

            // V_CTI_RESULT = ICAPI_CTI.ICRegisterAddress(
            //   toNumber(ds_ctiData.getColumn(0,"HANDLE"))
            // , g_ctiTelNo
            // , ds_ctiData.getColumn(0,"TENANT_NM")
            // , ""
            // );

            var registerResult = iCapi.ICRegisterAddress(
                _globalHandle,
                agentDn,
                "FoodVille",
                0
            );

            if (registerResult != 0)
            {
                lbl_LogLabel.Text = "ooo ooo ooo Error!! Error Code : " + registerResult;
            }

            // V_CTI_RESULT = ICAPI_CTI.ICAgentLogin(  
            //   toNumber(ds_ctiData.getColumn(0,"HANDLE"))
            // , g_ctiTelNo
            // , g_ctiId
            // , ds_ctiData.getColumn(0,"AGENT_PW")
            // , ds_ctiData.getColumn(0,"TENANT_NM")
            // , "60"
            // , 0
            // , 0
            // , ds_ctiData.getColumn(0,"AGENT_PW_TYPE")
            // );
            
            //3. 테스트정보
            // - 테스트 번호 : 070-4992-4804
            // - 테스트 계정 : FDVdev01, FDVdev01
            // - 패스워드 : 1
            // - 개발테스트큐 : 901096
            //
            // 인사멘트 : 반갑습니다. 투썸플레이스입니다.고객센터는 1번,  투썸 창업센터 문의는 2번, 부서안내는 3번을 눌러주세요.처음부터 다시 듣고 싶으시면 *표를 눌러주세요.
            //  - 메뉴 1번 선택 : 901096
            //  - 메뉴 3번 선택 : 901096

            var loginResult = iCapi.ICAgentLogin(
                _globalHandle,
                agentDn,
                userId,
                userPw,
                "FoodVille",
                60,
                0,
                0,
                2
            );

            if (loginResult != 0)
            {
                lbl_LogLabel.Text = "ooo ooo ooo Login Error! Error Code : " + loginResult;
            }

            var stateResult = iCapi.ICSetAgentState(
                _globalHandle,
                userId,
                "FoodVille",
                40,
                1,
                0
            );

            if (stateResult != 0)
            {
                lbl_LogLabel.Text = "ooo ooo ooo State Change Error! Error Code : " + stateResult;
            }
        }

        private void btn_AnswerCall_Click(object sender, EventArgs e)
        {
            // V_CTI_RESULT = ICAPI_CTI.ICAnswerCall(
            //   toNumber(ds_ctiData.getColumn(0,"HANDLE"))
            // , g_ctiTelNo
            // , ds_ctiData.getColumn(0,"CONN_ID")
            // , ds_ctiData.getColumn(0,"EXHANDLE")
            // );

            var agentDn = txt_AgentDn.Text;

            iCapi.ICAnswerCall(
                _globalHandle,
                agentDn,
                _connectionId,
                0
            );
        }

        private void btn_ClearCall_Click(object sender, EventArgs e)
        {
            // V_CTI_RESULT = ICAPI_CTI.ICClearCall(
            //  toNumber(ds_ctiData.getColumn(0,"HANDLE"))
            // , g_ctiTelNo
            // , gfn_nvl(ds_ctiData.getColumn(0,"CONN_ID2"),ds_ctiData.getColumn(0,"CONN_ID"))
            // , ds_ctiData.getColumn(0,"EXHANDLE")
            // );

            var agentDn = txt_AgentDn.Text;

            iCapi.ICClearCall(
                _globalHandle,
                agentDn,
                _connectionId,
                0
            );
        }

        private void btn_MakeCall_Click(object sender, EventArgs e)
        {
            //  V_CTI_RESULT = ICAPI_CTI.ICMakeCall(
            //   toNumber(ds_ctiData.getColumn(0,"HANDLE"))
            // , g_ctiTelNo
            // , g_vocCallprefix + pTargetDn
            // , pCallDn
            // , 0
            // , 0
            // , ""
            // , ""
            // , 0
            // , 0
            // , 0
            // , 0
            // , ""
            // , ds_ctiData.getColumn(0,"EXHANDLE")
            // );

            var vocCallPrefix = "630";
            var targetDn = txt_DestDn.Text;
            var agentDn = txt_AgentDn.Text;

            iCapi.ICMakeCall(
                _globalHandle,
                agentDn,
                vocCallPrefix + targetDn,
                "07049924804",
                0,
                0,
                "",
                "",
                0,
                0,
                0,
                0,
                "",
                0
            );
        }

        private void iCapi_Ringing(object sender, _DICAPIEvents_RingingEvent e)
        {
            _connectionId = e.conn_id;
            _thisDn = e.this_dn;

            txt_AnswerCallNumber.Text = e.ani_dn ?? e.other_dn;
        }

        private void iCapi_AgentLogin(object sender, _DICAPIEvents_AgentLoginEvent e)
        {
            _agentId = e.agent_id;
            _agentDn = e.agent_dn;
            _monitorid = e.monitorid;
        }

        private void iCapi_ResponseAgentLogin(object sender, _DICAPIEvents_ResponseAgentLoginEvent e)
        {
        }

        private void iCapi_ResponseAnswerCall(object sender, _DICAPIEvents_ResponseAnswerCallEvent e)
        {
        }

        private void SoftPhoneSample_FormClosed(object sender, FormClosedEventArgs e)
        {
            iCapi.ICAgentLogout(
                _globalHandle,
                _agentDn,
                _agentId,
                "",
                0
            );

            iCapi.ICUnregisterAddress(
                _globalHandle,
                _agentDn,
                "",
                _monitorid,
                0
            );

            iCapi.ICCloseServer(_globalHandle);
        }
    }
}