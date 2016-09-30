﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace EmotionPlatzi.Web.Models
{
    public class EmoFace
    {
        public int Id { get; set; }
        public int EmoPictureId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        #region Relaciones
        public virtual EmoPicture Picture { get; set; }  //one2many
        public virtual ObservableCollection<EmoEmotion> Emotions { get; set; } //many2one
        #endregion
    }
}