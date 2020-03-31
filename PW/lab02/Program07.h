const char NazwaProgramu[] = "Program07";
const int MaxX = 400;
const int MaxY = 300;
void Rysuj(HDC hdc, int x, int y,int r)
{
Ellipse(hdc, x-r, y-r, x+r, y+r);
}