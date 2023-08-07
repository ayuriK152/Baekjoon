x, y, w, s = map(int, input().split())

block = (x+y) * w

if (x + y) % 2 == 0 :
    angle = max(x,y) * s

else :
    angle = (max(x,y) - 1) * s + w

block_angle = min(x,y) * s + abs(x-y) * w

print(min(block, angle, block_angle))
