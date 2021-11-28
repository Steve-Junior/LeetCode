using System;

public class Solution
{
    public int[] CountPoints(int[][] points, int[][] queries)
    {
        var result = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            int count = 0;

            foreach (var point in points)
            {
                if (distance(point, queries[i]) <= radius(queries[i]))
                {
                    count += 1;
                }
            }

            result[i] = count;
        }

        return result;
    }

    private double distance(int[] point, int[] query)
    {
        //Distance between
        //P(x1,y1) and Q(x2,y2) is given by: d(P, Q) = √ (x2 − x1)^2 + (y2 − y1)^2

        var xPlane = Math.Pow(query[0] - point[0], 2);
        var yPlane = Math.Pow(query[1] - point[1], 2);
        return Math.Sqrt(xPlane + yPlane);
    }

    private double radius(int[] query)
    {
        //Distance between
        //Q(x2,y2) and Origin/Center (0, 0) is given by: d(P, Q) = √ (x2)^2 + (y2)^2
        return Math.Sqrt(Math.Pow(query[2], 2));
    }
}