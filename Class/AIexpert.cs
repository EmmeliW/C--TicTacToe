//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TicTackToe.Class
//{
//    class AIexpert
//    {
//        public int MiniMax(int depth, bool needMax, int alpha, int beta, out Board childWithMax)
//        {
//            childWithMax = null;
//            System.Diagnostics.Debug.Assert(m_TurnForPlayerX == needMax);
//            if (depth == 0 || IsTerminalNode())
//            {
//                RecursiveScore = m_Score;
//                return m_Score;
//            }
//            foreach (Board cur in GetChildren())
//            {
//                Board dummy;
//                int score = cur.MiniMax(depth - 1, !needMax, alpha, beta, out dummy);
//                if (!needMax)
//                {
//                    if (beta > score)
//                    {
//                        beta = score;
//                        childWithMax = cur;
//                        if (alpha >= beta)
//                        {
//                            break;
//                        }
//                    }
//                }
//                else
//                {
//                    if (alpha < score)
//                    {
//                        alpha = score;
//                        childWithMax = cur;
//                        if (alpha >= beta)
//                        {
//                            break;
//                        }
//                    }
//                }
//            }
//            RecursiveScore = needMax ? alpha : beta;
//            return RecursiveScore;
//        }
//    }
//}
