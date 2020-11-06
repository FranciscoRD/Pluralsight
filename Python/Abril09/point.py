class Point2D:
    def __init__(self, x, y):
        self.x = x
        self.y = y
    
    def __str__(self):
        return f"({self.x}, {self.y})"

    def __repr__(self):
        return f"Point2D(x={self.x}, y={self.y})"

    # def __format__(self, f):
    #     return f"[Formated point: {self.x}, {self.y} {f}]"

    def __format__(self, f):
        if f == 'r':
            return f"{self.y}, {self.x}"
        else:
            return f"{self.x}, {self.y}"

# os.system('cls')