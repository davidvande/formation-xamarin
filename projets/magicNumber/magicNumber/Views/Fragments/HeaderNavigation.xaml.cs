using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace magicNumber.Views.Fragments
{
    public partial class HeaderNavigation : ContentView
    {
        public HeaderNavigation()
        {
            InitializeComponent();

            Animate();
        }

        private void Animate()
        {
            var anim1 = new Animation(v => star1.Rotation = v, 0, 360);
            anim1.Commit(this, "Etoile 1", 16, 2000, null, null, () => true);

            var anim2 = new Animation(v => star2.Rotation = v, 0, 360);
            anim2.Commit(this, "Etoile 2", 16, 3000, null, null, () => true);

            var anim3 = new Animation(v => star3.Rotation = v, 0, 360);
            anim3.Commit(this, "Etoile 3", 16, 1000, null, null, () => true);

        }
    }
}
