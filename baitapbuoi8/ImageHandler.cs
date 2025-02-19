﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace baitapbuoi8
{
    public class ImageHandler
    {
        private string _bitmapPath;
        private Bitmap _CurrentBitmap;

        public Bitmap CurrentBitmap
        {
            get
            {
                if(_CurrentBitmap == null)
                    _CurrentBitmap = new Bitmap(1, 1);
                    return _CurrentBitmap;   
            }
            set
            {
                _CurrentBitmap = value;
            }
        }

        public string BitmapPath
        {
            get
            {
                return _bitmapPath;
            }
            set
            {
                _bitmapPath = value;
            }
        }
    }
}
