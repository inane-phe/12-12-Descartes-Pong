namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playground = new System.Windows.Forms.Panel();
            this.scores = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(98, 93);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 26);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // playground
            // 
            this.playground.Controls.Add(this.scores);
            this.playground.Controls.Add(this.points);
            this.playground.Controls.Add(this.gameover);
            this.playground.Controls.Add(this.racket);
            this.playground.Controls.Add(this.ball);
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1920, 1080);
            this.playground.TabIndex = 1;
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scores.Location = new System.Drawing.Point(7, 23);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(79, 32);
            this.scores.TabIndex = 2;
            this.scores.Text = "分數";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.points.Location = new System.Drawing.Point(92, 23);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(62, 32);
            this.points.TabIndex = 3;
            this.points.Text = "：0";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameover.Location = new System.Drawing.Point(333, 67);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(63, 20);
            this.gameover.TabIndex = 4;
            this.gameover.Text = "esc-esit";
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(228, 1010);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(185, 19);
            this.racket.TabIndex = 1;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
    }
}

