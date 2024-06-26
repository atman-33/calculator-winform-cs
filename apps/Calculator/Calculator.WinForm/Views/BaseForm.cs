﻿using Calculator.Domain.Exceptions;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Calculator.WinForm
{
    public partial class BaseForm : MetroForm
    {
        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif
        }

        /// <summary>
        /// 参照元から処理を実行すると共に、例外発生時は例外共通処理を行う。
        /// </summary>
        /// <param name="action">処理内容</param>
        /// <param name="memberInfo">呼び出し元のクラス情報</param>
        /// <param name="methodBase">呼び出し元の関数情報</param>
        protected void ExecuteWithErrorHandling(
            Action action,
            MemberInfo? memberInfo = null,
            MethodBase? methodBase = null)
        {
            try
            {
                if (memberInfo is not null || methodBase is not null)
                {
                    string info = memberInfo?.Name ?? string.Empty;
                    info = info != string.Empty ? info + "." : string.Empty;
                    info = info + methodBase?.Name ?? string.Empty;
                    info = $"👉 {info}";


                    // TODO: デバッグ出力 or ログファイル出力の処理を統括した関数をDomainに準備する方が良い
#if DEBUG
                    Debug.WriteLine(info);
#else
                    _logger.Info($"{info}");
#endif
                }

                action();
            }
            catch (Exception ex)
            {
                ExceptionProc(ex);
            }
        }

        /// <summary>
        /// 例外共通処理
        /// </summary>
        /// <param name="ex"></param>
        protected void ExceptionProc(Exception ex)
        {
#if DEBUG
            Debug.WriteLine(ex.Message);
#else
            _logger.Error(ex.Message, ex);
#endif

            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "エラー";
            var exceptionBase = ex as ExceptionBase;
            if (exceptionBase != null)
            {
                if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Info)
                {
                    icon = MessageBoxIcon.Information;
                    caption = "情報";
                }
                else if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Warning)
                {
                    icon = MessageBoxIcon.Warning;
                    caption = "警告";
                }
            }

            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// 起動時
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void BaseForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            Debug.WriteLine("🚀 open:" + this.Name);
#else
            Debug.WriteLine("🚀 open:" + this.Name);            
            _logger.Info("🚀 open:" + this.Name);
#endif
        }

        /// <summary>
        /// 終了時
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
#if DEBUG
            Debug.WriteLine("🌙 close:" + this.Name);
#else
            Debug.WriteLine("🚀 open:" + this.Name);            
            _logger.Info("🌙 close:" + this.Name);
#endif
        }
    }
}