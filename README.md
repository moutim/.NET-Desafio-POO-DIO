# DesafioPOO - Projeto em C# 📱

Este é um projeto desenvolvido em C# utilizando Programação Orientada a Objetos (POO), baseando-se nos pilares da POO: **Encapsulamento**, **Abstração**, **Herança** e **Polimorfismo**. O objetivo principal é simular as funcionalidades de um Smartphone, com métodos que abrangem desde a apresentação do aparelho até a instalação de aplicativos e realização de chamadas telefônicas.

## Funcionalidades Principais 🚀

### Apresentação do Smartphone
O método `ApresentarAparelho` exibe as principais informações do Smartphone, como modelo, capacidade de memória, número e IMEI.

### Instalação de Aplicativos
O método `InstalarAplicativo` permite a instalação de diferentes aplicativos no Smartphone, com a exibição de uma mensagem informativa.

### Realização de Ligações
Os métodos `Ligar` e `ReceberLigacao` simulam as ações de efetuar e receber chamadas telefônicas, respectivamente.

### Informações do Aparelho
Os métodos `ObterIMEI`, `ObterModelo` e `ObterMemoria` retornam, respectivamente, o número IMEI, modelo e capacidade de memória do Smartphone.

## Pilares da POO Implementados 🏛️

### Encapsulamento
As propriedades e métodos são encapsulados nas classes, garantindo o acesso controlado e a proteção dos dados.

### Abstração
A classe `Smartphone` e seus métodos refletem uma abstração do conceito de um Smartphone, concentrando-se nos aspectos essenciais do dispositivo.

### Herança
O projeto utiliza conceitos de herança para criar as classe `Iphone` e `Nokia`, que herda da classe abstrata `Smartphone`.

### Polimorfismo
Os métodos de ligação (`Ligar` e `ReceberLigacao`) demonstram o polimorfismo, adaptando-se aos diferentes números de telefone.

## Testes Unitários com xUnit 🧪

Todos os métodos foram submetidos a testes unitários utilizando a biblioteca xUnit. Isso garante que as funcionalidades do projeto estão corretamente implementadas e contribui para a manutenção da qualidade do código.

## Estrutura do Projeto 🏗️

O projeto é organizado em classes e métodos, seguindo os princípios da Programação Orientada a Objetos. As classes de testes, `NokiaTestes` e `IphoneTestes`, contêm casos de teste para garantir o funcionamento adequado de cada método.

## Como Utilizar 🛠️

1. Clone o repositório para sua máquina local.
2. Abra o projeto em seu ambiente de desenvolvimento C#.
3. Execute os testes unitários para verificar a integridade do código.
4. Integre as classes e métodos do projeto em sua aplicação, se necessário.
