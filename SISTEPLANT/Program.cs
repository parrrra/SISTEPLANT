using SISTEPLANT.Exercise1;
using SISTEPLANT.Exercise2;


int[] numbers = [268, 670, 0, -999];

foreach (var number in numbers)
{
    Console.WriteLine($"Max value by inserting '5' in {number}: {Exercise1.Solution(number)}");
}


int[][] arrays =
[
    [1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1],
    [0, 1, 1, 0, 0, 1, 1, 1, 0, 1],
    [1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1],
    [0, 0, 0, 0, 0, 0],
    [1, 1, 1, 1, 1]
];

foreach (var A in arrays)
{
    Console.WriteLine($"{{ {string.Join(", ", A)} }} index = {Exercise2.Solution(A)}");
}

//Los agrupo por distribuidor y si la cantidad de items distintos
//por distribuidor es igual al número total de items es que han comprado todos los items
string exercise3SQL = @"
    SELECT distributor_id
    FROM orders
    GROUP BY distributor_id
    HAVING COUNT(DISTINCT item_ordered) = (SELECT COUNT(*) FROM items);
";