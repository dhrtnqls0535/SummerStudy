﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        num1[,] dir = new num1[4, 4];      //배열 선언
        num2[,] dor = new num2[5, 5];
        num3[,] der = new num3[7, 7];

        int CharacterCoordinateX = 2;       //캐릭터와 공의 좌표 설정
        int CharacterCoordinateY = 3;
        int BallCoordinateX = 2;
        int BallCoordinateY = 2;

        int i = 1;                          //스테이지 번호
        int j = 0;                          //걸음 수

        struct num1
        {
            public int up;
            public int down;
            public int right;
            public int left;
        }

        struct num2
        {
            public int up;
            public int down;
            public int right;
            public int left;
        }

        struct num3
        {
            public int up;
            public int down;
            public int right;
            public int left;
        }

        public Form1()
        {
            InitializeComponent();                                              //기본 값 초기화
            map.SizeMode = PictureBoxSizeMode.StretchImage;
            map2.SizeMode = PictureBoxSizeMode.StretchImage;
            map3.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            character.SizeMode = PictureBoxSizeMode.StretchImage;
            map2.Visible = false;
            map3.Visible = false;
            label4.Text = "";

            button1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);

            int x = character.Location.X;                                       //캐릭터 위치 설정
            x = 511;
            int y = character.Location.Y;
            y = 281;

            character.Location = new Point(x, y);

            int a = ball.Location.X;                                            //공 위치 설정
            a = 511;
            int b = ball.Location.Y;
            b = 221;

            ball.Location = new Point(a, b);

            button2.Visible = false;
            label3.Text = "Stage 1";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ball_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


            int x = character.Location.X;
            int y = character.Location.Y;
            int a = ball.Location.X;
            int b = ball.Location.Y;

            num1 t1 = new num1();                               //벽의 유무 판별
            t1.up = 1;
            t1.down = 0;
            t1.right = 0;
            t1.left = 1;
            dir[0, 0] = t1;
            num1 t2 = new num1();
            t2.up = 1;
            t2.down = 0;
            t2.right = 0;
            t2.left = 0;
            dir[1, 0] = t2;
            num1 t3 = new num1();
            t3.up = 1;
            t3.down = 1;
            t3.right = 0;
            t3.left = 0;
            dir[2, 0] = t3;
            num1 t4 = new num1();
            t4.up = 1;
            t4.down = 1;
            t4.right = 1;
            t4.left = 0;
            dir[3, 0] = t4;
            num1 t5 = new num1();
            t5.up = 0;
            t5.down = 1;
            t5.right = 0;
            t5.left = 1;
            dir[0, 1] = t5;
            num1 t6 = new num1();
            t6.up = 0;
            t6.down = 0;
            t6.right = 0;
            t6.left = 0;
            dir[1, 1] = t6;
            num1 t7 = new num1();
            t7.up = 1;
            t7.down = 0;
            t7.right = 0;
            t7.left = 0;
            dir[2, 1] = t7;
            num1 t8 = new num1();
            t8.up = 1;
            t8.down = 0;
            t8.right = 1;
            t8.left = 0;
            dir[3, 1] = t8;
            num1 t9 = new num1();
            t9.up = 1;
            t9.down = 0;
            t9.right = 0;
            t9.left = 1;
            dir[0, 2] = t9;
            num1 t10 = new num1();
            t10.up = 0;
            t10.down = 1;
            t10.right = 1;
            t10.left = 0;
            dir[1, 2] = t10;
            num1 t11 = new num1();
            t11.up = 0;
            t11.down = 0;
            t11.right = 1;
            t11.left = 1;
            dir[2, 2] = t11;
            num1 t12 = new num1();
            t12.up = 0;
            t12.down = 0;
            t12.right = 1;
            t12.left = 1;
            dir[3, 2] = t12;
            num1 t13 = new num1();
            t13.up = 0;
            t13.down = 1;
            t13.right = 0;
            t13.left = 1;
            dir[0, 3] = t13;
            num1 t14 = new num1();
            t14.up = 1;
            t14.down = 1;
            t14.right = 0;
            t14.left = 0;
            dir[1, 3] = t14;
            num1 t15 = new num1();
            t15.up = 0;
            t15.down = 1;
            t15.right = 0;
            t15.left = 0;
            dir[2, 3] = t15;
            num1 t16 = new num1();
            t16.up = 0;
            t16.down = 1;
            t16.right = 1;
            t16.left = 0;
            dir[3, 3] = t16;
            num2 p1 = new num2();
            p1.up = 1;
            p1.down = 0;
            p1.right = 0;
            p1.left = 1;
            dor[0, 0] = p1;
            num2 p2 = new num2();
            p2.up = 1;
            p2.down = 1;
            p2.right = 0;
            p2.left = 0;
            dor[1, 0] = p2;
            num2 p3 = new num2();
            p3.up = 1;
            p3.down = 1;
            p3.right = 0;
            p3.left = 0;
            dor[2, 0] = p3;
            num2 p4 = new num2();
            p4.up = 1;
            p4.down = 1;
            p4.right = 0;
            p4.left = 0;
            dor[3, 0] = p4;
            num2 p5 = new num2();
            p5.up = 1;
            p5.down = 0;
            p5.right = 1;
            p5.left = 0;
            dor[4, 0] = p5;
            num2 p6 = new num2();
            p6.up = 0;
            p6.down = 1;
            p6.right = 0;
            p6.left = 1;
            dor[0, 1] = p6;
            num2 p7 = new num2();
            p7.up = 1;
            p7.down = 0;
            p7.right = 1;
            p7.left = 0;
            dor[1, 1] = p7;
            num2 p8 = new num2();
            p8.up = 1;
            p8.down = 0;
            p8.right = 0;
            p8.left = 1;
            dor[2, 1] = p8;
            num2 p9 = new num2();
            p9.up = 1;
            p9.down = 1;
            p9.right = 0;
            p9.left = 0;
            dor[3, 1] = p9;
            num2 p10 = new num2();
            p10.up = 0;
            p10.down = 0;
            p10.right = 1;
            p10.left = 0;
            dor[4, 1] = p10;
            num2 p11 = new num2();
            p11.up = 1;
            p11.down = 0;
            p11.right = 0;
            p11.left = 1;
            dor[0, 2] = p11;
            num2 p12 = new num2();
            p12.up = 0;
            p12.down = 0;
            p12.right = 1;
            p12.left = 0;
            dor[1, 2] = p12;
            num2 p13 = new num2();
            p13.up = 0;
            p13.down = 1;
            p13.right = 0;
            p13.left = 1;
            dor[2, 2] = p13;
            num2 p14 = new num2();
            p14.up = 1;
            p14.down = 0;
            p14.right = 0;
            p14.left = 0;
            dor[3, 2] = p14;
            num2 p15 = new num2();
            p15.up = 0;
            p15.down = 0;
            p15.right = 1;
            p15.left = 0;
            dor[4, 2] = p15;
            num2 p16 = new num2();
            p16.up = 0;
            p16.down = 0;
            p16.right = 0;
            p16.left = 1;
            dor[0, 3] = p16;
            num2 p17 = new num2();
            p17.up = 0;
            p17.down = 1;
            p17.right = 0;
            p17.left = 0;
            dor[1, 3] = p17;
            num2 p18 = new num2();
            p18.up = 1;
            p18.down = 1;
            p18.right = 0;
            p18.left = 0;
            dor[2, 3] = p18;
            num2 p19 = new num2();
            p19.up = 0;
            p19.down = 0;
            p19.right = 1;
            p19.left = 0;
            dor[3, 3] = p19;
            num2 p20 = new num2();
            p20.up = 0;
            p20.down = 0;
            p20.right = 1;
            p20.left = 1;
            dor[4, 3] = p20;
            num2 p21 = new num2();
            p21.up = 0;
            p21.down = 1;
            p21.right = 0;
            p21.left = 1;
            dor[0, 4] = p21;
            num2 p22 = new num2();
            p22.up = 1;
            p22.down = 1;
            p22.right = 0;
            p22.left = 0;
            dor[1, 4] = p22;
            num2 p23 = new num2();
            p23.up = 1;
            p23.down = 1;
            p23.right = 0;
            p23.left = 0;
            dor[2, 4] = p23;
            num2 p24 = new num2();
            p24.up = 0;
            p24.down = 1;
            p24.right = 1;
            p24.left = 0;
            dor[3, 4] = p24;
            num2 p25 = new num2();
            p25.up = 0;
            p25.down = 1;
            p25.right = 1;
            p25.left = 1;
            dor[4, 4] = p25;

            num3 r1 = new num3();
            r1.up = 1;
            r1.down = 0;
            r1.right = 0;
            r1.left = 1;
            der[0, 0] = r1;
            num3 r2 = new num3();
            r2.up = 1;
            r2.down = 0;
            r2.right = 0;
            r2.left = 0;
            der[1, 0] = r2;
            num3 r3 = new num3();
            r3.up = 1;
            r3.down = 0;
            r3.right = 0;
            r3.left = 0;
            der[2, 0] = r3;
            num3 r4 = new num3();
            r4.up = 1;
            r4.down = 0;
            r4.right = 0;
            r4.left = 0;
            der[3, 0] = r4;
            num3 r5 = new num3();
            r5.up = 1;
            r5.down = 1;
            r5.right = 0;
            r5.left = 0;
            der[4, 0] = r5;
            num3 r6 = new num3();
            r6.up = 1;
            r6.down = 1;
            r6.right = 1;
            r6.left = 0;
            der[5, 0] = r6;
            num3 r7 = new num3();
            r7.up = 1;
            r7.down = 0;
            r7.right = 1;
            r7.left = 1;
            der[6, 0] = r7;
            num3 r8 = new num3();
            r8.up = 0;
            r8.down = 0;
            r8.right = 0;
            r8.left = 1;
            der[0, 1] = r8;
            num3 r9 = new num3();
            r9.up = 0;
            r9.down = 1;
            r9.right = 0;
            r9.left = 0;
            der[1, 1] = r9;
            num3 r10 = new num3();
            r10.up = 0;
            r10.down = 0;
            r10.right = 1;
            r10.left = 0;
            der[2, 1] = r10;
            num3 r11 = new num3();
            r11.up = 0;
            r11.down = 0;
            r11.right = 0;
            r11.left = 1;
            der[3, 1] = r11;
            num3 r12 = new num3();
            r12.up = 1;
            r12.down = 1;
            r12.right = 0;
            r12.left = 0;
            der[4, 1] = r12;
            num3 r13 = new num3();
            r13.up = 1;
            r13.down = 0;
            r13.right = 0;
            r13.left = 0;
            der[5, 1] = r13;
            num3 r14 = new num3();
            r14.up = 0;
            r14.down = 0;
            r14.right = 1;
            r14.left = 0;
            der[6, 1] = r14;
            num3 r15 = new num3();
            r15.up = 0;
            r15.down = 0;
            r15.right = 1;
            r15.left = 1;
            der[0, 2] = r15;
            num3 r16 = new num3();
            r16.up = 1;
            r16.down = 0;
            r16.right = 0;
            r16.left = 1;
            der[1, 2] = r16;
            num3 r17 = new num3();
            r17.up = 0;
            r17.down = 0;
            r17.right = 1;
            r17.left = 0;
            der[2, 2] = r17;
            num3 r18 = new num3();
            r18.up = 0;
            r18.down = 1;
            r18.right = 1;
            r18.left = 1;
            der[3, 2] = r18;
            num3 r19 = new num3();
            r19.up = 1;
            r19.down = 0;
            r19.right = 0;
            r19.left = 1;
            der[4, 2] = r19;
            num3 r20 = new num3();
            r20.up = 0;
            r20.down = 0;
            r20.right = 1;
            r20.left = 0;
            der[5, 2] = r20;
            num3 r21 = new num3();
            r21.up = 0;
            r21.down = 0;
            r21.right = 0;
            r21.left = 1;
            der[6, 2] = r21;
            num3 r22 = new num3();
            r22.up = 0;
            r22.down = 0;
            r22.right = 1;
            r22.left = 1;
            der[0, 3] = r22;
            num3 r23 = new num3();
            r23.up = 0;
            r23.down = 0;
            r23.right = 0;
            r23.left = 1;
            der[1, 3] = r23;
            num3 r24 = new num3();
            r24.up = 0;
            r24.down = 0;
            r24.right = 0;
            r24.left = 0;
            der[2, 3] = r24;
            num3 r25 = new num3();
            r25.up = 1;
            r25.down = 1;
            r25.right = 0;
            r25.left = 0;
            der[3, 3] = r25;
            num3 r26 = new num3();
            r26.up = 0;
            r26.down = 1;
            r26.right = 0;
            r26.left = 0;
            der[4, 3] = r26;
            num3 r27 = new num3();
            r27.up = 0;
            r27.down = 0;
            r27.right = 1;
            r27.left = 0;
            der[5, 3] = r27;
            num3 r28 = new num3();
            r28.up = 0;
            r28.down = 0;
            r28.right = 1;
            r28.left = 1;
            der[6, 3] = r28;
            num3 r29 = new num3();
            r29.up = 0;
            r29.down = 0;
            r29.right = 0;
            r29.left = 1;
            der[0, 4] = r29;
            num3 r30 = new num3();
            r30.up = 0;
            r30.down = 0;
            r30.right = 0;
            r30.left = 0;
            der[1, 4] = r30;
            num3 r31 = new num3();
            r31.up = 0;
            r31.down = 0;
            r31.right = 0;
            r31.left = 0;
            der[2, 4] = r31;
            num3 r32 = new num3();
            r32.up = 1;
            r32.down = 0;
            r32.right = 1;
            r32.left = 0;
            der[3, 4] = r32;
            num3 r33 = new num3();
            r33.up = 1;
            r33.down = 0;
            r33.right = 0;
            r33.left = 1;
            der[4, 4] = r33;
            num3 r34 = new num3();
            r34.up = 0;
            r34.down = 1;
            r34.right = 0;
            r34.left = 0;
            der[5, 4] = r34;
            num3 r35 = new num3();
            r35.up = 0;
            r35.down = 1;
            r35.right = 1;
            r35.left = 0;
            der[6, 4] = r35;
            num3 r36 = new num3();
            r36.up = 0;
            r36.down = 0;
            r36.right = 1;
            r36.left = 1;
            der[0, 5] = r36;
            num3 r37 = new num3();
            r37.up = 0;
            r37.down = 0;
            r37.right = 0;
            r37.left = 1;
            der[1, 5] = r37;
            num3 r38 = new num3();
            r38.up = 0;
            r38.down = 1;
            r38.right = 0;
            r38.left = 0;
            der[2, 5] = r38;
            num3 r39 = new num3();
            r39.up = 0;
            r39.down = 1;
            r39.right = 0;
            r39.left = 0;
            der[3, 5] = r39;
            num3 r40 = new num3();
            r40.up = 0;
            r40.down = 0;
            r40.right = 0;
            r40.left = 0;
            der[4, 5] = r40;
            num3 r41 = new num3();
            r41.up = 1;
            r41.down = 0;
            r41.right = 0;
            r41.left = 0;
            der[5, 5] = r41;
            num3 r42 = new num3();
            r42.up = 1;
            r42.down = 0;
            r42.right = 1;
            r42.left = 0;
            der[6, 5] = r42;
            num3 r43 = new num3();
            r43.up = 0;
            r43.down = 1;
            r43.right = 0;
            r43.left = 1;
            der[0, 6] = r43;
            num3 r44 = new num3();
            r44.up = 0;
            r44.down = 1;
            r44.right = 0;
            r44.left = 0;
            der[1, 6] = r44;
            num3 r45 = new num3();
            r45.up = 1;
            r45.down = 1;
            r45.right = 0;
            r45.left = 0;
            der[2, 6] = r45;
            num3 r46 = new num3();
            r46.up = 1;
            r46.down = 1;
            r46.right = 1;
            r46.left = 0;
            der[3, 6] = r46;
            num3 r47 = new num3();
            r47.up = 0;
            r47.down = 1;
            r47.right = 0;
            r47.left = 1;
            der[4, 6] = r47;
            num3 r48 = new num3();
            r48.up = 0;
            r48.down = 1;
            r48.right = 0;
            r48.left = 0;
            der[5, 6] = r48;
            num3 r49 = new num3();
            r49.up = 0;
            r49.down = 1;
            r49.right = 1;
            r49.left = 0;
            der[6, 6] = r49;

            if (i == 1)                                     // 스테이지 1일때 키 입력을 받아 캐릭터와 공 이동
            {

                if (e.KeyCode == Keys.Right)
                {
                    if (dir[CharacterCoordinateX, CharacterCoordinateY].right == 0)                 //캐릭터의 오른쪽에 벽이 있는지 판별
                    {
                        if (BallCoordinateX == CharacterCoordinateX + 1 && BallCoordinateY == CharacterCoordinateY)         //캐릭터의 오른쪽에 공이 있는지 판별
                        {
                            if (dir[BallCoordinateX, BallCoordinateY].right == 0)                   //공의 오른쪽에 벽이 있는지 판별
                            {
                                x += 85;
                                CharacterCoordinateX += 1;
                                a += 85;
                                BallCoordinateX += 1;
                                j++;
                            }
                        }
                        else
                        {
                            x += 85;
                            CharacterCoordinateX += 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Left)
                {
                    if (dir[CharacterCoordinateX, CharacterCoordinateY].left == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX - 1 && BallCoordinateY == CharacterCoordinateY)
                        {
                            if (dir[BallCoordinateX, BallCoordinateY].left == 0)
                            {
                                x -= 85;
                                CharacterCoordinateX -= 1;
                                a -= 85;
                                BallCoordinateX -= 1;
                                j++;
                            }
                        }
                        else
                        {
                            x -= 85;
                            CharacterCoordinateX -= 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Up)
                {
                    if (dir[CharacterCoordinateX, CharacterCoordinateY].up == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX && BallCoordinateY == CharacterCoordinateY - 1)
                        {
                            if (dir[BallCoordinateX, BallCoordinateY].up == 0)
                            {
                                y -= 65;
                                CharacterCoordinateY -= 1;
                                b -= 65;
                                BallCoordinateY -= 1;
                                j++;
                            }
                        }
                        else
                        {
                            y -= 65;
                            CharacterCoordinateY -= 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Down)
                {
                    if (dir[CharacterCoordinateX, CharacterCoordinateY].down == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX && BallCoordinateY == CharacterCoordinateY + 1)
                        {
                            if (dir[BallCoordinateX, BallCoordinateY].down == 0)
                            {
                                y += 65;
                                CharacterCoordinateY += 1;
                                b += 65;
                                BallCoordinateY += 1;
                                j++;
                            }
                        }
                        else
                        {
                            y += 65;
                            CharacterCoordinateY += 1;
                            j++;
                        }
                    }
                }

                if (BallCoordinateX == 3 && BallCoordinateY == 0)                           //공이 목표지점에 도달했을때 클리어 메시지
                {
                    label1.Text = "Clear";
                    map.Visible = false;
                    character.Visible = false;
                    ball.Visible = false;
                    button2.Visible = true;
                    button1.Visible = false;
                    label3.Text = "";
                    label4.Text = "";
                }
                else
                {
                    label1.Text = "";
                }

            }

            if (i == 2)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (dor[CharacterCoordinateX, CharacterCoordinateY].right == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX + 1 && BallCoordinateY == CharacterCoordinateY)
                        {
                            if (dor[BallCoordinateX, BallCoordinateY].right == 0)
                            {
                                x += 87;
                                CharacterCoordinateX += 1;
                                a += 87;
                                BallCoordinateX += 1;
                                j++;
                            }
                        }
                        else
                        {
                            x += 87;
                            CharacterCoordinateX += 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Left)
                {
                    if (dor[CharacterCoordinateX, CharacterCoordinateY].left == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX - 1 && BallCoordinateY == CharacterCoordinateY)
                        {
                            if (dor[BallCoordinateX, BallCoordinateY].left == 0)
                            {
                                x -= 87;
                                CharacterCoordinateX -= 1;
                                a -= 87;
                                BallCoordinateX -= 1;
                                j++;
                            }
                        }
                        else
                        {
                            x -= 87;
                            CharacterCoordinateX -= 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Up)
                {
                    if (dor[CharacterCoordinateX, CharacterCoordinateY].up == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX && BallCoordinateY == CharacterCoordinateY - 1)
                        {
                            if (dor[BallCoordinateX, BallCoordinateY].up == 0)
                            {
                                y -= 80;
                                CharacterCoordinateY -= 1;
                                b -= 80;
                                BallCoordinateY -= 1;
                                j++;
                            }
                        }
                        else
                        {
                            y -= 80;
                            CharacterCoordinateY -= 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Down)
                {
                    if (dor[CharacterCoordinateX, CharacterCoordinateY].down == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX && BallCoordinateY == CharacterCoordinateY + 1)
                        {
                            if (dor[BallCoordinateX, BallCoordinateY].down == 0)
                            {
                                y += 80;
                                CharacterCoordinateY += 1;
                                b += 80;
                                BallCoordinateY += 1;
                                j++;
                            }
                        }
                        else
                        {
                            y += 80;
                            CharacterCoordinateY += 1;
                            j++;
                        }
                    }
                }

                if (BallCoordinateX == 4 && BallCoordinateY == 4)
                {
                    label1.Text = "Clear";
                    map2.Visible = false;
                    character.Visible = false;
                    ball.Visible = false;
                    button1.Visible = false;
                    button2.Visible = true;
                    label3.Text = "";
                    label4.Text = "";
                }

            }

            if (i == 3)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (der[CharacterCoordinateX, CharacterCoordinateY].right == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX + 1 && BallCoordinateY == CharacterCoordinateY)
                        {
                            if (der[BallCoordinateX, BallCoordinateY].right == 0)
                            {
                                x += 62;
                                CharacterCoordinateX += 1;
                                a += 62;
                                BallCoordinateX += 1;
                                j++;
                            }
                        }
                        else
                        {
                            x += 62;
                            CharacterCoordinateX += 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Left)
                {
                    if (der[CharacterCoordinateX, CharacterCoordinateY].left == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX - 1 && BallCoordinateY == CharacterCoordinateY)
                        {
                            if (der[BallCoordinateX, BallCoordinateY].left == 0)
                            {
                                x -= 62;
                                CharacterCoordinateX -= 1;
                                a -= 62;
                                BallCoordinateX -= 1;
                                j++;
                            }
                        }
                        else
                        {
                            x -= 62;
                            CharacterCoordinateX -= 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Up)
                {
                    if (der[CharacterCoordinateX, CharacterCoordinateY].up == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX && BallCoordinateY == CharacterCoordinateY - 1)
                        {
                            if (der[BallCoordinateX, BallCoordinateY].up == 0)
                            {
                                y -= 58;
                                CharacterCoordinateY -= 1;
                                b -= 58;
                                BallCoordinateY -= 1;
                                j++;
                            }
                        }
                        else
                        {
                            y -= 58;
                            CharacterCoordinateY -= 1;
                            j++;
                        }
                    }
                }

                else if (e.KeyCode == Keys.Down)
                {
                    if (der[CharacterCoordinateX, CharacterCoordinateY].down == 0)
                    {
                        if (BallCoordinateX == CharacterCoordinateX && BallCoordinateY == CharacterCoordinateY + 1)
                        {
                            if (der[BallCoordinateX, BallCoordinateY].down == 0)
                            {
                                y += 58;
                                CharacterCoordinateY += 1;
                                b += 58;
                                BallCoordinateY += 1;
                                j++;
                            }
                        }
                        else
                        {
                            y += 58;
                            CharacterCoordinateY += 1;
                            j++;
                        }
                    }
                }

                if (BallCoordinateX == 3 && BallCoordinateY == 2)
                {
                    label1.Text = "Clear";
                    map3.Visible = false;
                    character.Visible = false;
                    ball.Visible = false;
                    button1.Visible = false;
                    label3.Text = "";
                    label4.Text = "";
                }
                else
                {
                    label1.Text = "";
                }

            }
            label4.Text = "걸음 수: " + Convert.ToString(j);                           //걸음 수 표시

            if (label1.Text == "Clear")                                                      //클리어 화면일때 걸음 수를 표시하지 않음
            {
                label4.Text = "";
            }
            character.Location = new Point(x, y);
            ball.Location = new Point(a, b);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                j = 0;
                label4.Text = "걸음 수: 0";                                //걸음 수 초기화

                int x = character.Location.X;                             //캐릭터와 공 위치, 좌표 초기화
                x = 511;
                int y = character.Location.Y;
                y = 281;

                character.Location = new Point(x, y);

                int a = ball.Location.X;
                a = 511;
                int b = ball.Location.Y;
                b = 221;

                ball.Location = new Point(a, b);

                CharacterCoordinateX = 2;
                CharacterCoordinateY = 3;
                BallCoordinateX = 2;
                BallCoordinateY = 2;

                label1.Text = "";

                map.Visible = true;
                character.Visible = true;
                ball.Visible = true;
            }

            if (i == 2)
            {
                j = 0;
                label4.Text = "걸음 수: 0";                            //걸음 수 초기화

                int x = character.Location.X;                         //캐릭터와 공 위치, 좌표 초기화
                x = 310;
                int y = character.Location.Y;
                y = 370;

                character.Location = new Point(x, y);

                int a = ball.Location.X;
                a = 400;
                int b = ball.Location.Y;
                b = 205;

                ball.Location = new Point(a, b);

                CharacterCoordinateX = 0;
                CharacterCoordinateY = 4;
                BallCoordinateX = 1;
                BallCoordinateY = 2;
            }

            if (i == 3)
            {
                j = 0;
                label4.Text = "걸음 수: 0";                        //걸음 수 초기화

                int x = character.Location.X;                     //캐릭터와 공 위치, 좌표 초기화
                x = 300;
                int y = character.Location.Y;
                y = 35;

                character.Location = new Point(x, y);

                int a = ball.Location.X;
                a = 610;
                int b = ball.Location.Y;
                b = 325;

                ball.Location = new Point(a, b);


                CharacterCoordinateX = 0;
                CharacterCoordinateY = 0;
                BallCoordinateX = 5;
                BallCoordinateY = 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;

            if (i == 2)
            {
                j = 0;                                      //걸음 수와 공, 캐릭터의 위치와 좌표 초기화
                label4.Text = "걸음 수: 0";
                label3.Text = "Stage 2";
                map.Visible = false;
                map2.Visible = true;
                character.Visible = true;
                ball.Visible = true;
                button2.Visible = false;
                label1.Text = "";
                button1.Visible = true;
                int x = character.Location.X;
                x = 310;
                int y = character.Location.Y;
                y = 370;

                character.Location = new Point(x, y);

                int a = ball.Location.X;
                a = 400;
                int b = ball.Location.Y;
                b = 205;

                ball.Location = new Point(a, b);


                CharacterCoordinateX = 0;
                CharacterCoordinateY = 4;
                BallCoordinateX = 1;
                BallCoordinateY = 2;
            }

            if (i == 3)
            {
                j = 0;
                label4.Text = "걸음 수: 0";
                label3.Text = "Stage 3";
                map.Visible = false;
                map2.Visible = false;
                map3.Visible = true;
                character.Visible = true;
                ball.Visible = true;
                button2.Visible = false;
                label1.Text = "";
                button1.Visible = true;
                int x = character.Location.X;
                x = 300;
                int y = character.Location.Y;
                y = 35;

                character.Location = new Point(x, y);

                int a = ball.Location.X;
                a = 610;
                int b = ball.Location.Y;
                b = 325;

                ball.Location = new Point(a, b);


                CharacterCoordinateX = 0;
                CharacterCoordinateY = 0;
                BallCoordinateX = 5;
                BallCoordinateY = 5;
                character.Size = new Size(40, 40);
                ball.Size = new Size(38, 38);

            }

        }

    }

}
