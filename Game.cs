using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string key, out int x, out int y) {
        // No acabo de entender lo del out
        x = 0;
        y = 0;
        switch (key) {
          case "UpArrow":
            y--;
            break;
          case "DownArrow":
            y++;
            break;
          case "LeftArrow":
            x--;
            break;
          case "RightArrow":
            x++;
            break;
        }
    }
    
    public new static char UpdateCursor(string key) {
        switch (key) {
          case "UpArrow":
            return '^';
          case "DownArrow":
            return 'v';
          case "LeftArrow":
            return '<';
          case "RightArrow":
            return '>';
          default:
            return ' ';
        }
    }

    public new static int KeepInBounds(int coord, int max) {
      if (coord < 0) {
        return 0;
      } else if (coord >= max) {
        return max - 1;
      } else {
        return coord;
      }
    }

    public new static bool DidScore(int x, int y, int fruitX, int fruitY) {
      if (x == fruitX && y == fruitY) {
        return true;
      } else {
        return false;
      }
    }
  }
}