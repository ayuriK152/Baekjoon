#include <iostream>
#include <vector>
using namespace std;

int n;
int count;
vector<pair<int, int>> coords;
bool col[15];
bool diagL[29];
bool diagR[29];

void Recursive(int xin, int yin)
{
	if (yin == n - 1) {
		::count++;
		return;
	}

	col[xin] = true;
	diagL[xin + yin] = true;
	diagR[n - xin - 1 + yin] = true;

	for (int x = 0; x < n; x++)
	{
		if (!col[x] && !diagL[x + yin + 1] && !diagR[n - x + yin])
		{
			Recursive(x, yin + 1);
		}
	}

	col[xin] = false;
	diagL[xin + yin] = false;
	diagR[n - xin - 1 + yin] = false;
}

int main()
{
	::count = 0;
	cin >> n;
	
	for (int x = 0; x < n; x++)
	{
		Recursive(x, 0);
	}

	cout << ::count;

	return 0;
}