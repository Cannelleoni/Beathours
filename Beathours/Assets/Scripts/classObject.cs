using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classObject
{
    static int posX;
    static int posY;
    static bool free = true;
    static int level;

    public classObject(int _posX, int _posY, bool _free, int _level) {
        posX = _posX;
        posY = _posY;
        free = _free;
        level = _level;
    }
}
