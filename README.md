# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Contexto
Foi solicitado que se fizesse uma abstração de um celular e disponibilizasse maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Deve-se criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.
