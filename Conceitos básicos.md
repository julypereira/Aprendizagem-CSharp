# Curso de C#

**Conceitos básicos do C# .Net Framework**
* [Aula 05](https://www.youtube.com/watch?v=K7JTSy5InCU&list=PLPc-V1ujthioJ8Cq_yMzYAbeSvaPye-aa&index=5) - O NetFramework
* .NET Framework é uma tecnologia que dá suporte à criação e execução Windows aplicativos e serviços Web.
* O .NET Framework é um ambiente de execução gerenciado para o Windows que oferece uma variedade de serviços aos aplicativos em execução. Ele consiste em dois componentes principais: o CLR (Common Language Runtime), o mecanismo de execução que manipula aplicativos em execução, e a biblioteca de classes .NET Framework, que oferece uma biblioteca de códigos testados e reutilizáveis que os desenvolvedores podem chamar de seus próprios aplicativos. 
* O .NET Framework pode ser utilizado para desenvolver os seguintes tipos de aplicativos e serviços:

  * Aplicativos de console.

  * Aplicativos GUI do Windows (Windows Forms).

  * Aplicativos WPF (Windows Presentation Foundation).

  * Aplicativos ASP.NET.

  * Serviços do Windows.

  * Aplicativos orientados a serviço usando o WCF (Windows Communication Foundation).

  * Aplicativos habilitados para fluxo de trabalho usando o Windows Workflow Foundation (WF).
#

**Sintaxe básica da linguagem**
* [Aula 06](https://www.youtube.com/watch?v=vNGhKJHjXEg&list=PLPc-V1ujthioJ8Cq_yMzYAbeSvaPye-aa&index=6) - Variáveis em C#
* As variáveis são utilizadas para armazenar informações na memória em tempo de execução da aplicação, isso significa que essas informações estarão disponíveis enquanto a aplicação estiver em execução e, mais precisamente, enquanto a classe ou método em que ela foi criada estiver em execução.
* A regra para nomear uma variável é que o nome dela sempre comece por uma **letra** ou **_**.
* No meio do nome podem-se usar números, mas não se devem usar caracteres especiais e também não pode ser uma palavra reservada.
* No C# toda variável deve ter: modificador de acesso, tipo de dados e nome.
  * __Modificadores:__ 
    * Definem a visibilidade das variáveis, se elas poderão ser acessadas por outras classes que não seja a sua própria, se serão acessadas somente por classes derivadas a classe que ela está e assim por diante.
    * Quando uma variável é declarada sem um modificador de acesso o compilador atribui o modificador padrão private.

      ![img_modificadores](https://user-images.githubusercontent.com/87590342/201533654-677de170-7ac0-4c29-9220-c4e4fc11b12b.PNG)

  * __Tipos de dados__:
    * C# é uma linguagem de programação fortemente tipada, isso significa que todas as variáveis e objetos devem ter um tipo declarado.
    * O valor atribuído a uma variável deve estar de acordo com o seu tipo declarado.
    * Os tipos de dados são divididos em __*value types*__ e __*reference types*__.


      * __value types__
        * Derivados de _System.ValueType_
        * Contém dentro delas um valor
        * Dentro de Value Type existem duas categorias: struct e enum.
         1. Struct: é dividida em tipos numéricos, bool e estruturas personalizadas pelo usuário.

         ![img_struck](https://user-images.githubusercontent.com/87590342/201534734-0d9dc692-e0e5-4a4e-8539-19caea34cf9d.PNG)


         3. Enum: permite criar um tipo que é formado por várias constantes. 


         ![img_enum](https://user-images.githubusercontent.com/87590342/201535889-c82fa0ae-29a1-4b43-bf44-05aa5c2fe4a5.PNG)


      * __reference types__
        * Derivados de _System.Object_
        * Contém uma referência
        * Os tipos de referência são: class, interface, delegate, object, string e Array.
          * Tipo object: todos os tipos são derivados da classe Object, sendo assim é possível converter qualquer tipo para object.
          * Tipo string: é utilizado para se armazenar caracteres e uma string deve estar entre aspas,
    
    
   
     * Dentro de Value Type existem duas categorias: struct e enum.



  * __Nome__:
    * No caso das varáveis, os modificadores definem a visibilidade delas, se elas poderão ser acessadas por outras classes que não seja a sua própria, se serão acessadas somente por classes derivadas a classe que ela está e assim por diante.
