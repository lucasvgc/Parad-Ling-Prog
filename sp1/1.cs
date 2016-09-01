/*
Bom, temos a função 1, em que é declarado o tipo int à B, é lhe é atribuido -100.
Na função 2, também é declarado int pra B, que agora recebe -200.
No final das duas há o printf, mas não é exibido na tela agora, pois não está na main().
Entrando na main(), B é declarado como int, e recebe 10.
Agora sim, é printado o "Valor de B: 10".
Depois B recebe 20.
A função 1 é chamada e é printado na tela "Valor de B dentro da função func1: -100".
Agora é printado na tela o novo valor de B, declarado antes na main. "Valor de B: 20".
B agora recebe 30.
Agora é printado o printf da função 2, Valor de B dentro da função func2: -200.
Agora é printado o valor de B definido antes, "Valor de B: 30".

Valor de B: 10
Valor de B dentro da função func1: -100
Valor de B: 20
Valor de B dentro da função func2: -200
Valor de B: 30

Obs: Pro clrscr(); funcionar, aqui pelo menos, tem que incluir a biblioteca <stdlib.h>.
*/