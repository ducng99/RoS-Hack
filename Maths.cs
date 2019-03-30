using System;

namespace TheCheat
{
    internal class Maths
    {
        public static bool InsideCircle(int centerX, int centerY, int fov, int targetX, int targetY)
        {
            int dx = centerX - targetX;
            int dy = centerY - targetY;
            return dx * dx + dy * dy <= fov * fov;
        }

        public static int GetDistance(Vector3 v1, Vector3 v2, int Divide)
        {
            Vector3 vector3 = new Vector3();
            vector3.X = v1.X - v2.X;
            vector3.Y = v1.Y - v2.Y;
            vector3.Z = v1.Z - v2.Z;
            return (int)Math.Sqrt(Math.Pow(vector3.X, 2.0) + Math.Pow(vector3.Y, 2.0) + Math.Pow(vector3.Z, 2.0)) / Divide;
        }

        public static float[] ViewMatrix = new float[16];

        public static bool WorldToScreen(Vector3 pos, out Vector2 target, int windowWidth, int windowHeight)
        {
            target = new Vector2();
            Maths.ViewMatrix = Mem.ReadMatrix<float>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.BaseAddress + Offsets.ViewMatrix) + 4) + 196, 16);
            Vector4 vector4;
            vector4.X = (pos.X * Maths.ViewMatrix[0] + pos.Y * Maths.ViewMatrix[4] + pos.Z * Maths.ViewMatrix[8]) + Maths.ViewMatrix[12];
            vector4.Y = (pos.X * Maths.ViewMatrix[1] + pos.Y * Maths.ViewMatrix[5] + pos.Z * Maths.ViewMatrix[9]) + Maths.ViewMatrix[13];
            vector4.Z = (pos.X * Maths.ViewMatrix[2] + pos.Y * Maths.ViewMatrix[6] + pos.Z * Maths.ViewMatrix[10]) + Maths.ViewMatrix[14];
            vector4.W = (pos.X * Maths.ViewMatrix[3] + pos.Y * Maths.ViewMatrix[7] + pos.Z * Maths.ViewMatrix[11]) + Maths.ViewMatrix[15];
            bool flag;
            if (vector4.W < 0.100000001490116)
            {
                flag = false;
            }
            else
            {
                Vector3 vector3;
                vector3.X = vector4.X / vector4.W;
                vector3.Y = vector4.Y / vector4.W;
                vector3.Z = vector4.Z / vector4.W;
                target.X = (windowWidth / 2 * vector3.X + vector3.X + (windowWidth / 2));
                target.Y = (-(windowHeight / 2 * vector3.Y) + vector3.Y + (windowHeight / 2));
                flag = true;
            }
            return flag;
        }
    }
}
