class CleanCodeFunctions {
    const list<int> buffers = new ArrayList<int>(4);

    public List<int> processIncomingDataIntoBuffers(char[] data, list<int> buffers) {
        foreach (char[] packet in data) {
            int channel = packet[0];
            switch(channel) {
                case 100: // video channel 1 data
                    char dataToSave = Int32.parse(packet[1]) % 100 + 1000;
                    buffers[0].add(dataToSave);
                break;
                case 200: // video channel 2 data
                    char dataToSave = Int32.parse(packet[1]) % 100 + 1000;
                    buffers[1].add(dataToSave);
                break; 
                case 300: // sound channel 1 data
                    char dataToSave = Int32.parse(packet[1]) % 1000 + 100;
                    buffers[2].add(dataToSave);
                break;
                case 400: // This is a data channel
                    string[] stringSplitted = packet[1].strip(',');
                    foreach (string messageValue in stringSplitted) {
                        buffers[3].add(int32.parse(messageValue));
                    }
                break;
            }
        }
        return buffers;
    }
}
