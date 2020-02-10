public class Fila
{
    private object[] elements;
    private int rear, front, tam, cont = 0;

    public Fila(int max)
    {
        tam = max;
        elements = new object[tam];
        front = 0;
        rear = 0;

    }


    public void Insert(object x)
    {
        if (FilaCheia())
            throw new Exception("Fila Cheia");

        else
        {
            elements[rear] = x;

            if (rear == tam - 1)
                rear = 0;
            else
                rear++;

            cont++;
        }
    }

    public object Remove()
    {
        object x;

        if (FilaVazia())
            throw new Exception("Fila Vazia");

        else
        {
            x = elements[front];
            cont--;
            if (front > tam)
            {
                front = 0;
            }
            else
                front++;
        }
        return x;
    }

    public bool FilaCheia()
    {
        return cont == tam;
    }

    public bool FilaVazia()
    {

        return cont == 0;
    }
}
