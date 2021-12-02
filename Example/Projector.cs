using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Example
{
    internal class Projector : ISampleInterface
    {
        public bool IsValid { get; private set; }
 
        public bool TryAddProjection(ISimpleProjection projection)
        {
            if (projection == null) { throw new ArgumentNullException(nameof(projection)); }
            if (!IsValid) { return false; }
 
            foreach (var value in projection.Values)
            {
                var xPos = value.xPos;
                var yPos = value.yPos;
                var zPos = value.zPos;
                var a = value;
                if(xPos > yPos) {
                    return true;
                }
                if(yPos > zPos) {
                    return false;
                }
                if(xPos > zPos) {
                    return false;
                }
                if(yPos < zPos) {
                    return true;
                }
                //Add comment small extension, and another one
            }
            foreach (var value in projection.Values)
            {
                var xPos = value.xPos;
                var yPos = value.yPos;
                var zPos = value.zPos;
                var a = value;
                if(xPos > yPos) {
                    return true;
                }
                if(xPos > zPos) {
                    return false;
                }
                if(yPos < zPos) {
                    return true;
                } else {
                    return false;
                }
                //Add comment small extension
            }
            return true;
        }

        public void Test(bool value){
            var unused = value;
            return;
        }
    }
}