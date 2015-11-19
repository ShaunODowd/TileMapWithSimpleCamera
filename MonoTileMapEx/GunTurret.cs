using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimatedSprite;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AimingExample
{
    class GunTurret : RotatingSprite
    {
        const float GunTurretTurnSpeed = 0.025f;

        public GunTurret(AimingGame g, Texture2D tx, Vector2 StartPosition, int NoOfFrames)
            : base(g, tx, StartPosition, NoOfFrames)
        {
            
        }

        public override void Update(GameTime gametime)
        {
            base.Update(gametime);
        }
        public void follow(Sprite sp)
        {
            // 
            this.angleOfRotation = TurnToFace(position, 
                sp.position, angleOfRotation, GunTurretTurnSpeed);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

    }
}
