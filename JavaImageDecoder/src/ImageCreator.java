import java.io.InputStream;

public class ImageCreator {

    public void makeStream() throws Exception
    {
        InputStream inputStream = null;
        inputStream = this.getClass().getResourceAsStream("i");
        short[] arrayOfShort = fillShortArray(inputStream);
    }

    public short[] fillShortArray(InputStream inputStream) throws Exception
    {
        byte[] arrayOfByte = new byte[2];
        inputStream.read(arrayOfByte, 0, 2);
        short localTownsmen3 = (short)(arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF);
        short[] arrayOfShort = new short[localTownsmen3];
        for (short i = 0; i < localTownsmen3; i++)
        {
            inputStream.read(arrayOfByte, 0, 2);
            arrayOfShort[i] = ((short)(arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF));
        }
        return arrayOfShort;
    }
}
