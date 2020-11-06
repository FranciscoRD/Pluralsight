values = [x / (x - y) 
            for x in range(100) 
                if x > 50 
                    for y in range(100) 
                        if x - y != 0]

values = []
for x in range(100):
    if x > 50:
        for y in range(100):
            if x - y != 100:
                values.append(x / (x - y))

[(x, y) for x in range(10) for y in range(x)]

result = []
for x in range(10):
    for y in range(x):
        result.append((x,y))