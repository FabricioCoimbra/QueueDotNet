// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int main(void)
//{
    Console.WriteLine("\n\n\n");
    Node? raiz = new();

    // Mostrando a lista.
    int zero = 0;
    Console.WriteLine($"Inserindo novo item: {zero}\n");
    insereElemento(raiz, zero);
    if (raiz is not null)
        imprimePilha(raiz);

    int um = 1;
    Console.WriteLine($"Inserindo novo item: {um}\n");
    insereElemento(raiz, um);
    if (raiz is not null)
        imprimePilha(raiz);

    int dois = 2;
    Console.WriteLine($"Inserindo novo item: {dois}\n");
    insereElemento(raiz, dois);
    if (raiz is not null)
        imprimePilha(raiz);

    Console.WriteLine($"Removendo item: {dois}\n");
    removeElemento(raiz);
    if (raiz is not null)
        imprimePilha(raiz);

    Console.WriteLine($"Removendo item: {um}\n");
    removeElemento(raiz);
    if (raiz is not null)
        imprimePilha(raiz);

    Console.WriteLine($"Removendo item: {zero}\n");
    removeElemento(raiz);
    if (raiz is not null)
        imprimePilha(raiz);

    free(raiz);



return 0;
//}

void imprimePilha(Node? raiz)
{
    raiz = raiz?.Proximo;
    Console.WriteLine("Mostrando a pilha:\n");
    if (raiz is null)
    {
        Console.WriteLine("Pilha vazia.\n\n");
        return;
    }
        
    do
    {
        Console.WriteLine($"Mostrando {raiz.valor}");
        raiz = raiz.Proximo;
    } while (raiz is not null);
    Console.WriteLine("Terminei de mostrar a pilha \n\n");        
}

void removeElemento(Node? raiz)
{
    var anterior = raiz;
    //do
    //{
    //    Console.WriteLine($"Percorendo {raiz?.valor}");
    //    anterior = raiz;
    //    raiz = raiz.Proximo;
    //} while (raiz is not null);

    //Console.WriteLine($"Removendo {anterior?.valor}");
    //if (anterior is not null)
    //{
    //    anterior.Proximo = null;
    //}
    
}
void insereElemento(Node raiz, int info) => 
    raiz.Proximo = new() { valor = info };

void free(Node? raiz)
{
    while (raiz is not null)    
        removeElemento(raiz);
}