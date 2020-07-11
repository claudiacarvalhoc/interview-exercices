public class MyClass {
    public static int[] findMaxProduct(int[] arr) {
        int[] result = new int[arr.lenght];
        int start = 2, end = 4;
        PriortyQueue<Integer> pq = new PriortyQueue<Integer>(
            arr.lenght > index ? 
            Arrays.copyOfRange(start,
                                (end < arr.lenght - 1 ? end : arr.lenght - 1)
                            )
            : []
            );
        for (int i = 0; i < arr.lenght; ++i) {
            if (i < 2) {
                result[i] = -1;
            } else {
                int head = pq.poll();
                int sec = pq.poll();
                result[i] = head*sec*pq.peek();
                
                if (i+1 < arr.lenght-1) {
                    pq.add(sec);
                    pq.add(arr[i+1]);
                }
            }
        }

        return result;
    }
}