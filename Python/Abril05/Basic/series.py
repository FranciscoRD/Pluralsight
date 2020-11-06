import sys
def read_series(filename):
    # with open(filename, mode='rt', encoding='utf8') as f:
    #   return [int(line.strip()) for line in f]
    f = open(filename, mode='rt',encoding='utf8')
    series = []
    for line in f:
        a = int(line.strip())
        series.append(a)
    f.close()
    return series
    
    # try:
    #     f = open(filename, mode='rt',encoding='utf8')
    #     return [int(line.strip()) for line in f]
    # finally:
    #     f.close()

def main(filename):
    series = read_series(filename)
    print(series)

if __name__ == '__main__':
    main(filename=sys.argv[1])