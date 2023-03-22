n, m = map(int,input().split())
lst = []
res = [[0] * (m+1) for _ in range(n+1)]

for i in range(n) :
    lst.append(list(map(int,input().split())))

for i in range(1, n+1) :
    for j in range(1, m+1) :
        res[i][j] = lst[i-1][j-1] + res[i-1][j] + res[i][j-1] - res[i-1][j-1]
for _ in range(int(input())) :
    i,j,x,y = map(int,input().split())
    print(res[x][y] - res[x][j-1] - res[i-1][y] + res[i-1][j-1])