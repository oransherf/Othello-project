﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Othelo
{
    class Cell
    {
        public const char EMPTY = ' ';
        private char m_Sign = EMPTY;
        private int m_Row;
        private int m_Column;

        public Cell(int i_Row, int i_Column)
        {
            Row = i_Row;
            Column = i_Column;
        }
        public Cell()
        {
            
        }
        
        public int Row
        {
            get
            {
                return m_Row;
            }
            set
            {
                m_Row = value;
            }
        }

        public int Column
        {
            get
            {
                return m_Column;
            }
            set
            {
                m_Column = value;
            }
        }
        public char Sign
        {
            get
            {
                return m_Sign;
            }
            set
            {
                m_Sign = value;
            }
        }
        public bool IsEmpty()
        {
            bool isCellEmpty;
            if(Sign == EMPTY)
            {
                isCellEmpty = true;
            }
            else
            {
                isCellEmpty = false;
            }

            return isCellEmpty;
        }
    }
}
