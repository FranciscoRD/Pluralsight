f = open('wasteland.txt', mode = 'wt', encoding='utf8')
# w=write | t=text (wt)
# r=read   a=append | b=binary 
f.write('Hola\n')
f.write('Mundo\n')
f.write('Como\n')
f.write('Estas?')
f.close()
# los cambios son visibles hasta que se cierra el documento