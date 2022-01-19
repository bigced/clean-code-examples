class CleanCode {


    public List<int []> getThem() {
        List<int []> list1 = new ArrayList<int[]>();
        foreach (int[] x in theList)
            if (x[0] == 4)
            list1.add(x);
        return list1;

    }
}