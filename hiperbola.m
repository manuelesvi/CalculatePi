# grafica y analisis de -x^2-10x
x=-20:0.1:10;
c=[-1 -10 0]; # coeficientes polinomio (3 términos)
y=polyval(c, x); # valores de la función en rango x = (-20..10)

# paso 1
r=roots (c); #[-10 0] # encuentra las 2 raíces

# paso 2, 1er derivada
#1er derivada
d=polyder (c); #[-2 -10]

# coord. y de 1er derivada (pendiente curva)
z=polyval(d,x);

#recta tangente de un punto (a,b) = f'(a)*(x-a)+f(a)

#primera raiz x = r(1) = -10, y = f(a) = 0
t1=polyval(d, r(1))*(x-r(1))+0;
#segunda raiz x = r(2) = 0, y = f(a) = 0
t2=polyval(d, r(2))*(x-r(2))+0;

#max y - centro
max=roots(d); # raíz de la derivada = -5

maxy = polyval(c, max) * 2;
miny = polyval(c, -20);

# paso 3 - grafica
plot(x,y, x,t1, x,t2, x,z,max*ones(1,251),miny:1:maxy, r(1), 0, "marker", "*", r(2), 0, "marker", "*", max, 0, "marker", "*")
legend("f(x) = -x^2-10x", "tangente raiz 1", "tangente raiz 2", "pendiente curva")
