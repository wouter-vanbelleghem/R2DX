using R2DX.Common;
using System;
using System.Windows.Forms;

namespace R2DX.Control.Windows
{
    public partial class Main : Form
    {        
        private AIState _AIStatus;
        private Common.Functions _AIFunctions =  new Common.Functions();

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     What do I have to do on Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
        }

        /// <summary>
        ///     Initialises everything
        /// </summary>
        private void Start()
        {
            _AIStatus = _AIFunctions.getAIState();
        }

        /// <summary>
        ///     Returns state of AI Service
        /// </summary>
        /// <returns>true=AI service is running</returns>
        private bool IsAIRunning()
        {
            bool tmp = false;
            
            
                        
            return tmp;
        }
   }
}
