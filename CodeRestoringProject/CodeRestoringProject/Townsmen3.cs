using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRestoringProject
{
    public class Townsmen3 //extends MIDlet implements CommandListener, ItemCommandListener
    {
        private int[] hugeArrayWithNumbers = { 81920032, 1025, 81920064, 1026, 530, 4, -16544795, 4, -16694203, 1028, -16676459, 
                              1028, -16039467, 1028, -16661611, 1028, -16646139, 1028, -16756043, 4, 48658, 32, -16465435, 32, 
                              -16152235, 1056, 1661010003, 1056, 3041, 38, -16774747, 38, 627347, 38, 1661471075, 1062,
                              35858, 33, 1661010003, 1057, 1089, 5, 16842835, 1029, 164291, 1029, 449, 10, -16777163, 10, 
                              119443, 10, 1661028707, 1034, 465, 45, 496180, 45, -16772539, 45, 168462707, 45, 1661010003, 
                              1069, 465, 46, 709267, 46, 739683, 1070, 465, 48, -16772683, 48, 739699, 1072, 465, 47, 9016003,
                              1071, 1661010003, 1071, 2449, 6, 1661010003, 1030, 14610, 7, -16105435, 1031, -16301131, 1031, 
                              -16284763, 1031, -16317483, 1031, -16268251, 1031, -16120843, 1031, 1661010003, 1031, 33, 41, 
                              -16776171, 41, 9016003, 1065, 1661059155, 1049641, 1009, 40, -16776187, 40, 9016003, 1064, 
                              1661059155, 1049640, 977, 28, -16776219, 28, 9016003, 1052, 1661059155, 1049628, 945, 29, 
                              -16776251, 29, 9016003, 1053, 1661059155, 1049629, 929, 30, 9016003, 1054, 1661059155, 1049630, 
                              1057, 31, -16776139, 31, 9016003, 1055, 1661059155, 1049631, 1, 8, -16772523, 8, 9016003, 1032, 
                              1661010003, 1049608, 0, 4107, 2513, 12, -16777163, 12, 610963, 1036, 1661421923, 12, 2817, 37, 
                              -16774379, 37, 397971, 37, 1661077859, 37, 0, 4109 };
        public static int b;
        private String[] c;
        private Vector d;
        private Vector e;
        private int f;
        public static sbyte[] g;
        public bool h;
        private B i;
        private String j;
        private String k;
        private bool l;
        private int m;
        public int n;
        private int o;
        public static bool[] p;
        private Displayable q;
        private List r;
        private Vector s;
        private Form t;
        private Vector u;
        static sbyte[,] objectFieldByteMatrix;
        static byte[] w;
        static byte[][][] x;
        static byte[] y;
        static byte[] z;
        static short[][] aa;
        static byte[][][] ba;
        static byte[][] ca;
        static byte[][] da;
        static short[][][] ea;
        static byte[][][] fa;
        static byte[][] ga;
        static byte[][][] ha;
        static byte[][][] ia;
        static byte[] ja;
        static byte[] ka;
        static byte[] la;
        static byte[] ma;
        static short[] na;
        static short[] oa;
        static byte[] pa;
        static byte[] qa;
        static byte[] ra;
        static byte[] sa;
        static byte[] ta;
        static byte[] ua;
        static short[] va;
        static byte[] wa;
        static byte[] xa;
        static short[] ya;
        static short[] za;
        InputStream inputStreamAA = null;
        static short[] bA = { 0, 68, 36, 2, 0, 1, 72, 65, -2, -38, 2, 68, 36, 2, 0, 3, 68, 36, 2, 0, 4, 68, 51, 1, -19,
                                5, 66, 61, 3, -32, 6, 64, 68, 0, -34, 8, 61, 64, 4, -36, 10, 63, 59, 6, -31, 11, 64, 61, 
                                2, -30, 13, 64, 66, 1, -33, 14, 72, 64, 0, -32, 15, 63, 75, 3, -42, 16, 63, 92, 3, -60, 17, 
                                62, 64, 4, -34, 18, 67, 77, 2, -43, 19, 68, 36, 2, 0, 34, 24, 24, 0, 0, 33, 28, 28, 0, 0, 
                                32, 28, 28, 0, 0, 23, 7, 10, 1, -3, 27, 32, 32, 0, 0, 28, 50, 26, 0, 0, 26, 7, 6, 0, 0, 30, 
                                12, 12, 0, 0, 20, 61, 39, 5, -7, 21, 14, 16, -7, -17, 22, 32, 20, -16, -22, 24, 24, 24, 0, 
                                0, 25, 28, 18, -14, -25, 45, 7, 7, 0, 0, 46, 45, 48, 0, 0, 47, 58, 56, 20, -40, 48, 58, 58, 
                                0, 0, 49, 30, 30, 0, 0, 50, 30, 30, 0, 0, 52, 12, 16, 0, 0, 51, 12, 16, 0, 0, 53, 14, 16, -7, 
                                -17, 54, 14, 16, -7, -17, 55, 45, 48, 0, 0, 56, 45, 48, 0, 0, 57, 58, 56, 20, -40, 58, 20, 18, 
                                -10, -22, 59, 12, 16, 0, 0, 60, 40, 62, 0, 0, 61, 30, 30, 0, 0, 62, 14, 16, -7, -17, 63, 45, 
                                28, 0, 0, 37, 24, 24, 0, 0, 40, 240, 46, 0, 0, 41, 240, 49, 0, -28, 42, 240, 26, 0, 0, 43, 
                                240, 242, 0, 0, 44, 240, 52, 0, 0 };
        private String[] cA;
        private String[] dA;
        private int eA;
        private int fA;
        private int gA;
        private int hA;
        private bool iA = true;
        private short jA = 0;
        private short kA;
        private int lA;
        private int mA = 0;
        private int nA = 0;
        private int oA = 0;
        private bool pA = true;
        private int qA = 156;
        public short[] rA = new short[6];
        int sA = 0;
        private bool tA = false;
        private int uA;
        private int[] vA;
        public byte[] wA = new byte[2];
        private int xA;
        private int yA;
        private int zA;
        private int ab;
        private int bb;
        private int cb;
        private int db;
        private int eb;
        private int fb;
        private int gb;
        private int hb;
        private int ib;
        private int jb;
        char[] kb;
        char[] lb;
        private byte[][] mb = { { 0, 0, 1, 1, 6, 0, 0, 0, 0 }, { 1, 20, 1, 1, 6, -1, 0, 0, 1 }, 
                              { 2, 21, 1, 1, 6, -1, 0, 0, 1 }, { 3, 22, 1, 1, 6, -1, 0, 0, 1 }, 
                              { 4, 23, 1, 1, 6, -1, 0, 0, 1 }, { 5, 1, 1, 1, 6, 0, 0, 0, 1 }, 
                              { 6, 2, 1, 1, 6, 0, 0, 0, 1 }, { 7, 0, 1, 1, 6, 0, 0, 0, 1 }, 
                              { 8, 3, 1, 1, 6, 0, 0, 0, 1 }, { 9, 15, 1, 1, 10, 0, 0, 0, 1 }, 
                              { 10, 16, 1, 1, 10, 0, 0, 0, 1 }, { 11, 17, 1, 1, 10, 0, 0, 0, 1 }, 
                              { 12, 19, 1, 1, 10, 0, 0, 0, 1 }, { 13, 18, 1, 1, 10, 0, 0, 0, 1 }, 
                              { 14, 10, 1, 1, 10, 0, 0, 0, 1 }, { 15, 11, 1, 1, 10, 0, 0, 0, 1 }, 
                              { 16, 12, 1, 1, 10, 0, 0, 0, 1 }, { 17, 13, 1, 1, 10, 0, 0, 0, 1 }, 
                              { 18, 14, 1, 1, 10, 0, 0, 0, 1 }, { 19, 5, 1, 1, 10, 0, 0, 0, 1 }, 
                              { 20, 6, 1, 1, 10, 0, 0, 0, 1 }, { 21, 33, 1, 1, 6, 0, 0, 0, 1 }, 
                              { 22, 35, 1, 1, 6, 0, 0, 0, 1 } };
        Object[] nb;
        private int ob;
        private int pb;
        public Image[] qb = new Image[64];
        public bool[] rb = new bool[64];
        public bool sb = false;
        private bool[] tb = new bool[55];
        byte[] ub = new byte[55];
        short[] vb = new short[55];
        short[] wb = new short[55];
        bool xb = false;
        public static Font yb;
        public static Random zb = new Random();
        public static Font aB;
        public int bB;
        public long cB;
        public bool dB;
        public int eB;
        public int fB;
        public bool gB = false;
        public bool hB = false;
        public int iB = -1;
        public int jB = -1;
        public int kB = -1;
        public bool lB = false;
        public bool mB = true;
        public bool nB = true;
        public String oB = null;
        public A pB = null;
        public byte qB = 50;
        public bool rB = false;
        public int sB = 0;
        public int tB = 0;
        public int uB = 0;
        public byte vB = 0;
        public byte wB = 0;
        public String[] xB = new String[5];
        public String yB;
        public bool zB = true;
        public bool ac = false;
        public bool bc = false;
        public A cc;
        byte[] dc = new byte[2];
        bool ec = false;
        int fc = 0;
        bool gc = true;
        bool hc = false;
        bool ic = false;
        byte jc = 0;
        bool kc = false;
        byte lc = 0;
        bool mc = false;
        public byte nc = 0;
        String oc;
        String pc;
        public bool qc = false;
        public int rc = 0;
        public int sc = 0;
        public int tc = 0;
        public bool uc = false;
        private ChoiceGroup vc;
        private ChoiceGroup wc;
        public Graphics xc;
        public bool yc = false;
        bool[] zc = new bool[6];
        int aC = 0;
        private short[][] bC;
        private short[][] cC;
        Vector dC = new Vector();
        int eC = 0;
        int fC = 0;
        int gC = 0;
        byte[][] hC = new byte[8][2];
        byte iC = 0;
        Vector jC = new Vector();
        Vector kC = new Vector();
        Vector lC = new Vector();
        Vector mC = new Vector();
        Vector nC = new Vector();
        Vector oC = new Vector();
        Vector pC = new Vector();
        Vector qC = new Vector();
        Vector rC = new Vector();
        Vector sC = new Vector();
        Vector tC = new Vector();
        Vector uC = new Vector();
        public int vC;
        public int wC;
        public int xC;
        public int yC;
        public int zC;
        public int ad;
        public int bd;
        public int cd;
        public int dd;
        public A[][] ed;
        public byte fd = 0;
        int[] gd = { 0, -1, 0, 1, 2, -1, 3, -1, 0, 4, 0, 5, 0, 6, 0, 7, 0, 8, 0, 9, 0, 10, 0, 11, 0, 12, 2, 13, 0, 14, 0, 
                       15, 0, 25 };
        int hd = 0;
        public int id;
        public int jd;
        public int kd;
        public int ld;
        int md = 0;
        public int[] nd = { 0, 10, 2, 3, 7, 1, 4, 11, 5, 6, 13, 12, 14, 15 };
        public Vector od = new Vector();
        public D pd = null;
        public int qd = 1000;
        Vector rd = new Vector();
        byte[] sd = null;
        byte td = 0;
        int ud = 0;
        bool vd = false;
        int wd = 0;
        int[] xd = null;
        int yd = 0;
        int[] zd = null;
        String aD = null;
        int[] bD = null;
        int cD = 0;
        int dD = 0;
        int eD = -1;
        int fD = 0;
        int gD = 0;
        int hD = 0;
        int iD = 0;
        int jD = 0;
        String kD = null;
        bool lD = false;
        int mD = 0;
        bool nD = true;
        int oD = 0;
        int pD = 0;
        int qD = 0;
        int rD = 0;
        byte sD = 0;
        D tD;
        bool uD = false;
        int vD = 0;
        int wD;
        public short xD = 0;
        int[] yD;
        int[] zD;
        public short ae;
        public byte be;
        public int[][] ce = new int[3][8];
        public A[] de = new A[8];
        public int ee;
        public static byte[][] fe = { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 2 }, { 0, 2 }, { 2, 2 }, { 2, 2 }, 
                                    { 2, 2 }, { 2, 2 }, { 2, 2 }, { 2, 2 }, { 2, 2 }, { 2, 2 }, { 2, 2 }, { 2, 2 } };
        int[] ge;
        int he;
        int ie;
        byte je = -1;
        Vector ke = new Vector(1);
        int le;
  
        public bool checkRecordStore(int paramInt)
        {
            try
            {
                paramInt = RecordStore.openRecordStore("ByteStorage" + paramInt, false);
            }
            catch (Exception localException1)
            {
                return false;
            }
            if (paramInt != null) {
                try
                {
                    paramInt.closeRecordStore();
                }
                catch (Exception localException2) {}
            }
            return true;
        }
  
        private void B(int paramInt)
        {
            if (!checkRecordStore(paramInt)) {
                return;
            }
            try
            {
                this = RecordStore.openRecordStore("ByteStorage" + paramInt, false);
                if (getNumRecords() == 1) {
                    deleteRecord(1);
                }
                closeRecordStore();
                RecordStore.deleteRecordStore("ByteStorage" + paramInt);
            }
            catch (Exception localException) {}
        }
  
        private byte[] A(int paramInt, bool parambool)
        {
            this = null;
            try
            {
                this = RecordStore.openRecordStore("ByteStorage" + paramInt, false);
                paramInt = getRecord(1);
            }
            catch (Exception localException1)
            {
                paramInt = new byte[1];
                paramInt[0] = 0;
            }
            if (this != null) {
                try
                {
                closeRecordStore();
                }
                catch (Exception localException2) {}
            }
            return paramInt;
        }
  
        private int A(byte[] paramArrayOfByte, int paramInt)
        {
            return A(paramArrayOfByte, paramInt, -1, false);
        }
  
        private int A(byte[] paramArrayOfByte, int paramInt1, int paramInt2, bool parambool)
        {
            int i1 = 0;
            parambool = null;
            paramInt2 = 0;
            try
            {
                parambool = RecordStore.openRecordStore("ByteStorage" + paramInt1, true);
                if (parambool.getNumRecords() < 1)
                {
                parambool.addRecord(paramArrayOfByte, 0, 1);
                paramInt2 = 1;
                }
                if (parambool.getSizeAvailable() < paramArrayOfByte.length * 2)
                {
                i1 = 2;
                }
                else
                {
                parambool.setRecord(1, paramArrayOfByte, 0, paramArrayOfByte.length);
                paramInt2 = 0;
                }
            }
            catch (Exception paramArrayOfByte)
            {
                paramArrayOfByte = paramArrayOfByte.getMessage();
                if (paramArrayOfByte.compareTo("javax/microeditions/rms/RecordStoreNotFoundException") == 0) {
                i1 = 2;
                } else {
                i1 = 1;
                }
            }
            if (parambool != null) {
                try
                {
                parambool.closeRecordStore();
                if (paramInt2 != 0) {
                    B(paramInt1);
                }
                }
                catch (Exception localException) {}
            }
            return i1;
        }
  
        private bool[] A(int paramInt1, int paramInt2)
        {
            bool[] arrayOfbool = new bool[paramInt2];
            this = null;
            try
            {
                this = RecordStore.openRecordStore("boolStorage" + paramInt1, false);
                byte[] arrayOfByte = getRecord(1);
                for (paramInt1 = 0; paramInt1 < paramInt2; paramInt1++) {
                if (arrayOfByte[paramInt1] == 0) {
                    arrayOfbool[paramInt1] = true;
                }
                }
            }
            catch (Exception localException1)
            {
                for (paramInt1 = 0; paramInt1 < paramInt2; paramInt1++) {
                arrayOfbool[paramInt1] = true;
                }
                paramInt1 = 0;
                paramInt1++;
                paramInt1++;
                paramInt1++;
                paramInt1++;
                arrayOfbool[4] = false;
            }
            if (this != null) {
                try
                {
                closeRecordStore();
                }
                catch (Exception localException2) {}
            }
            return arrayOfbool;
        }
  
        private void A(bool[] paramArrayOfbool, int paramInt)
        {
            byte[] arrayOfByte = new byte[paramArrayOfbool.length];
            for (this = 0; this < paramArrayOfbool.length; this++) {
                arrayOfByte[this] = ((byte)(paramArrayOfbool[this] != 0 ? 0 : 1));
            }
            this = null;
            try
            {
                this = RecordStore.openRecordStore("boolStorage" + paramInt, true);
                while (getNumRecords() < 1) {
                addRecord(arrayOfByte, 0, 1);
                }
                setRecord(1, arrayOfByte, 0, arrayOfByte.length);
            }
            catch (Exception localException1) {}
            if (this != null) {
                try
                {
                closeRecordStore();
                }
                catch (Exception localException2) {}
            }
        }
  
        private void openTextsByLocaleName(String paramString)
        {
            try
            {
                InputStream localInputStream = getClass().getResourceAsStream("/" + paramString + ".lng");
                this = new byte[2];
                localInputStream.read(this, 0, 2);
                paramString = ((this[1] + 256) % 256 << 8 | (this[0] + 256) % 256) - 2;
                this = new byte[paramString];
                if (localInputStream.read(this) == paramString) {
                g = this;
                }
            }
            catch (Exception localException) {}
        }
  
        public static String D(int paramInt)
        {
            if (g == null) {
                return "null";
            }
            paramInt++;
            paramInt *= 2;
            if ((paramInt < 0) || (paramInt >= g.length)) {
                return "";
            }
            int i1 = (g[(paramInt + 4)] + 256) % 256 << 8 | (g[(paramInt + 3)] + 256) % 256;
            paramInt = (g[(paramInt + 2)] + 256) % 256 << 8 | (g[(paramInt + 1)] + 256) % 256;
            byte[] arrayOfByte = new byte[i1 - paramInt];
            System.arraycopy(g, paramInt, arrayOfByte, 0, arrayOfByte.length);
            switch (g[0])
            {
            case 0: 
                return new String(arrayOfByte, 0, arrayOfByte.length).replace('\r', '\n');
            case 1: 
                StringBuffer localStringBuffer = new StringBuffer(arrayOfByte.length / 2);
                for (paramInt = 0; paramInt < arrayOfByte.length - 1; paramInt += 2) {
                localStringBuffer.append((char)((arrayOfByte[(paramInt + 1)] + 256) % 256 << 8 | (arrayOfByte[paramInt] + 256) % 256));
                }
                return localStringBuffer.toString().replace('\r', '\n');
            case 2: 
                paramInt = new byte[arrayOfByte.length + 2];
                paramInt[0] = ((byte)(arrayOfByte.length >>> 8));
                paramInt[1] = ((byte)arrayOfByte.length);
                System.arraycopy(arrayOfByte, 0, paramInt, 2, arrayOfByte.length);
                try
                {
                return new DataInputStream(new ByteArrayInputStream(paramInt)).readUTF().replace('\r', '\n');
                }
                catch (Exception localException) {}
            }
            return null;
        }
  
        byte[] A()
            {
            byte[] arrayOfByte2 = null;
            try
            {
                byte[] arrayOfByte1 = new byte[2];
                this.inputStreamAA.read(arrayOfByte1, 0, 2);
                int i2 = arrayOfByte1[0] << 8 & 0xFF00 | arrayOfByte1[1] & 0xFF;
                arrayOfByte2 = new byte[i2];
                for (int i1 = 0; i1 < i2; i1++)
                {
                this.inputStreamAA.read(arrayOfByte1, 0, 1);
                arrayOfByte2[i1] = arrayOfByte1[0];
                }
            }
            catch (Exception localException) {}
            return arrayOfByte2;
        }
  
        sbyte[,] makeSbyteMatrix()
        {
            sbyte[,] arrayOfSbyte1;
            try
            {
                sbyte[] arrayOfSbyte = new sbyte[2];
                // the sbyte array is filled from the inputstream
                this.inputStreamAA.read(arrayOfSbyte, 0, 2);
                int i4 = arrayOfSbyte[0] << 8 & 0xFF00 | arrayOfSbyte[1] & 0xFF;
                this.inputStreamAA.read(arrayOfSbyte, 0, 2);
                int i3 = arrayOfSbyte[0] << 8 & 0xFF00 | arrayOfSbyte[1] & 0xFF;
                arrayOfSbyte1 = new sbyte[i4,i3];
                for (int i2 = 0; i2 < i4; i2++) 
                {
                    for (int i1 = 0; i1 < i3; i1++)
                    {
                        this.inputStreamAA.read(arrayOfSbyte, 0, 1);
                        arrayOfSbyte1[i2][i1] = arrayOfSbyte[0];
                    }
                }
            }
            catch (Exception localException) {}
            return arrayOfSbyte1;
        }
  
        short[] D()
        {
            short[] arrayOfShort = null;
            try
            {
                byte[] arrayOfByte = new byte[2];
                this.inputStreamAA.read(arrayOfByte, 0, 2);
                int i2 = arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF;
                arrayOfShort = new short[i2];
                for (int i1 = 0; i1 < i2; i1++)
                {
                this.inputStreamAA.read(arrayOfByte, 0, 2);
                arrayOfShort[i1] = ((short)(arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF));
                }
            }
            catch (Exception localException) {}
            return arrayOfShort;
        }
  
        short[][] E()
        {
            short[][] arrayOfShort = (short[][])null;
            try
            {
                byte[] arrayOfByte = new byte[2];
                this.inputStreamAA.read(arrayOfByte, 0, 2);
                int i4 = arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF;
                this.inputStreamAA.read(arrayOfByte, 0, 2);
                int i3 = arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF;
                arrayOfShort = new short[i4][i3];
                for (int i2 = 0; i2 < i4; i2++) {
                for (int i1 = 0; i1 < i3; i1++)
                {
                    this.inputStreamAA.read(arrayOfByte, 0, 2);
                    arrayOfShort[i2][i1] = ((short)(arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF));
                }
                }
            }
            catch (Exception localException) {}
            return arrayOfShort;
        }
  
        protected void startApp()
        {
            if (b == -1) {
                J(1);
            }
        }
  
        protected void pauseApp()
        {
            if (this.nc > 0)
            {
                this.nc = ((byte)(this.nc - 1));
            }
            else
            {
                this.h = true;
                this.mc = true;
                O(1);
                O(2);
                O(3);
                O(4);
            }
            this.sc = 0;
            this.pA = true;
        }
  
        private Displayable E(int paramInt)
        {
            Object localObject2 = null;
            Object localObject1 = null;
            for (int i7 = 0; i7 < this.hugeArrayWithNumbers.length; i7 += 2)
            {
                int i6 = this.hugeArrayWithNumbers[i7];
                int i5 = this.hugeArrayWithNumbers[(i7 + 1)];
                if (paramInt == (i5 & 0x3FF))
                {
                int i2;
                Alert localAlert;
                switch (i6 & 0xF)
                {
                case 2: 
                    int i1;
                    switch (i6 >> 4 & 0xF)
                    {
                    case 1: 
                    i1 = 3;
                    break;
                    case 3: 
                    i1 = 2;
                    break;
                    case 2: 
                    i1 = 1;
                    break;
                    default: 
                    i1 = 0;
                    }
                    this.r = new List(D(i6 >> 8 & 0x3FF), i1);
                    this.s = new Vector();
                    localObject2 = this.r;
                    ((Displayable)localObject2).setCommandListener(this);
                    this.f = i6;
                    break;
                case 5: 
                    Image localImage1 = null;
                    if (i6 >>> 24 != 255) {
                    localImage1 = this.qb[(i6 >>> 24)];
                    }
                    if (this.t != null)
                    {
                    if (localImage1 != null) {
                        this.t.append(localImage1);
                    } else {
                        this.t.append(D(i6 >> 4 & 0x3FF));
                    }
                    }
                    else if (this.r != null)
                    {
                    this.r.append(D(i6 >> 4 & 0x3FF), localImage1);
                    this.s.addElement(new Integer(i6 >> 14 & 0x3FF | i5 & 0x3C00));
                    }
                    break;
                case 3: 
                    switch (i5 >>> 20 & 0xF)
                    {
                    case 0: 
                    default: 
                    i2 = 1;
                    break;
                    case 1: 
                    i2 = 2;
                    }
                    ((Displayable)localObject2).addCommand(new Command(D(i6 >> 4 & 0x3FF), i2, i6 >>> 24 << 13 | i5 & 0x3C00 | i6 >> 14 & 0x3FF));
                    break;
                case 9: 
                    if (localObject1 != null)
                    {
                    switch (i5 >>> 20 & 0xF)
                    {
                    default: 
                        i2 = 1;
                        break;
                    case 1: 
                        i2 = 2;
                        break;
                    case 2: 
                        i2 = 4;
                    }
                    ((Item)localObject1).addCommand(new Command(D(i6 >> 4 & 0x3FF), i2, i6 >>> 24 << 13 | i5 & 0x3C00 | i6 >> 14 & 0x3FF));
                    }
                    break;
                case 0: 
                    localObject2 = new B(this, i6 >>> 14, i5 & 0x3C00 | i6 >> 4 & 0x3FF);
                    ((Displayable)localObject2).setCommandListener(this);
                    this.f = i6;
                    break;
                case 6: 
                    localAlert = new Alert(D(i6 >> 4 & 0x3FF));
                    if (paramInt == 8)
                    {
                    char[] arrayOfChar = new String("11/07/05 13:34:46").toCharArray();
                    localAlert.setString("(c) 20" + arrayOfChar[6] + arrayOfChar[7] + " " + D(i6 >> 14 & 0x3FF) + "\n" + getAppProperty("MIDlet-Version"));
                    }
                    else
                    {
                    localAlert.setString(D(i6 >> 14 & 0x3FF));
                    }
                    int i3 = (i6 >>> 24) * 50;
                    localAlert.setTimeout(i3 == 0 ? -2 : i3);
                    localObject2 = localAlert;
                    break;
                case 1: 
                    this.t = new Form(D(i6 >> 4 & 0x3FF));
                    localObject2 = this.t;
                    ((Displayable)localObject2).setCommandListener(this);
                    this.u = new Vector();
                    this.f = i6;
                    break;
                case 7: 
                    Image localImage2 = null;
                    if (i6 >>> 24 != 255) {
                    localImage2 = this.qb[(i6 >>> 24)];
                    }
                    if (this.t != null)
                    {
                    switch (i6 >> 14 & 0x3FF)
                    {
                    }
                    localObject1 = new ImageItem(D(i6 >> 4 & 0x3FF), localImage2, 0, D(localAlert >> 14 & 0x3FF));
                    this.t.append((Item)localObject1);
                    }
                    break;
                case 8: 
                    if (this.t != null)
                    {
                    localObject1 = new StringItem(D(i6 >> 4 & 0x3FF), D(localAlert >> 14 & 0x3FF), 0);
                    this.t.append((Item)localObject1);
                    }
                    break;
                case 4: 
                    int i4;
                    switch (i6 >>> 22)
                    {
                    case 0: 
                    i4 = 0;
                    break;
                    case 1: 
                    i4 = 1;
                    break;
                    case 2: 
                    i4 = 2;
                    break;
                    case 3: 
                    i4 = 65536;
                    break;
                    case 4: 
                    i4 = 3;
                    break;
                    case 5: 
                    i4 = 4;
                    break;
                    default: 
                    i4 = 0;
                    }
                    this.u.addElement(new Integer(this.t.size() | localAlert >>> 10 << 8));
                    this.t.append(new TextField(D(i6 >> 4 & 0x3FF), this.c[(localAlert >>> 10)], i6 >> 14 & 0xFF, i4));
                }
                if (localObject1 != null) {
                    ((Item)localObject1).setItemCommandListener(this);
                }
                }
            }
            return (Displayable)localObject2;
        }
  
        private int G(int paramInt)
        {
            for (int i1 = 0; i1 < this.d.size(); i1++) {
                if (((Integer)this.d.elementAt(i1)).intValue() >>> 8 == paramInt) {
                return i1;
                }
            }
            return -1;
        }
  
        private void B(int paramInt1, int paramInt2)
        {
            paramInt2 |= paramInt1 << 8;
            paramInt1 = G(paramInt1);
            if (paramInt1 == -1) {
                this.d.addElement(new Integer(paramInt2));
            } else {
                this.d.setElementAt(new Integer(paramInt2), paramInt1);
            }
        }
  
        private int H(int paramInt)
        {
            paramInt = G(paramInt);
            if (paramInt == -1) {
                return 0;
            }
            return ((Integer)this.d.elementAt(paramInt)).intValue() & 0xFF;
        }
  
        private int G()
        {
            int i1 = ((Integer)this.e.lastElement()).intValue();
            this.e.removeElement(this.e.lastElement());
            return i1;
        }
  
        public void J(int paramInt)
        {
            Y();
            b = paramInt;
            X();
            System.gc();
        }
  
        public void A(int paramInt, String paramString1, String paramString2)
        {
            Y();
            this.j = paramString1;
            this.k = paramString2;
            b = paramInt;
            X();
            this.j = null;
            this.k = null;
            System.gc();
        }
  
        public void B(int paramInt, bool parambool)
        {
            Y();
            this.l = parambool;
            this.m = paramInt;
            b = paramInt;
            X();
            System.gc();
        }
  
        public void K(int paramInt)
        {
            this.i.e = false;
            this.o = this.n;
            AA();
            this.n = paramInt;
            Z();
            if (this.i != null) {
                this.i.e = true;
            }
        }
  
        void A(Graphics paramGraphics, int paramInt1, int paramInt2, int paramInt3)
        {
            this.ub[17] = ((byte)paramInt1);
            this.vb[17] = ((short)(paramInt2 + 2));
            this.wb[17] = ((short)(paramInt3 + 2));
            B(paramGraphics, 17);
            this.vb[18] = ((short)paramInt2);
            this.wb[18] = ((short)paramInt3);
            B(paramGraphics, 18);
        }
  
        void A(Graphics paramGraphics, int paramInt1, int paramInt2, int paramInt3, bool parambool)
        {
            this.ub[this.gd[(paramInt1 * 2)]] = 0;
            this.vb[this.gd[(paramInt1 * 2)]] = ((short)paramInt2);
            this.wb[this.gd[(paramInt1 * 2)]] = ((short)paramInt3);
            B(paramGraphics, this.gd[(paramInt1 * 2)]);
            A localA = this.ed[this.jd][this.id];
            if ((localA.i == 0) && (localA.a >= 6)) {
                if ((parambool) && (localA.e > -1))
                {
                if (this.fd == 0)
                {
                    if ((localA.y) && (localA.a != 15))
                    {
                    A tmp133_131 = localA;
                    tmp133_131.b = ((byte)(tmp133_131.b - 1));
                    if (localA.b <= 1) {
                        localA.y = false;
                    }
                    }
                    else
                    {
                    A tmp163_161 = localA;
                    tmp163_161.b = ((byte)(tmp163_161.b + 1));
                    if (localA.b >= 3) {
                        localA.y = true;
                    }
                    }
                    A tmp190_188 = localA;
                    tmp190_188.b = ((byte)(tmp190_188.b % T(paramInt1)));
                    if ((localA.b == 0) && (localA.a != 15)) {
                    localA.b = 1;
                    }
                }
                }
                else {
                localA.b = 1;
                }
            }
            if (localA.a >= 6)
            {
                this.ub[paramInt1] = 0;
                this.vb[paramInt1] = ((short)paramInt2);
                this.wb[paramInt1] = ((short)paramInt3);
                B(paramGraphics, paramInt1);
            }
            if (this.wd == 11)
            {
                this.ub[paramInt1] = this.de[this.ee].b;
            }
            else if ((this.eD == 104) || (this.cD == 114))
            {
                this.ub[paramInt1] = 0;
                this.vb[paramInt1] = ((short)paramInt2);
                this.wb[paramInt1] = ((short)paramInt3);
                B(paramGraphics, paramInt1);
                this.ub[paramInt1] = 1;
            }
            else
            {
                this.ub[paramInt1] = this.ed[this.jd][this.id].b;
            }
            this.vb[paramInt1] = ((short)paramInt2);
            this.wb[paramInt1] = ((short)paramInt3);
            B(paramGraphics, paramInt1);
            if (this.ed[this.jd][this.id].w)
            {
                paramInt1 = 38;
                if (this.ed[this.jd][this.id].x) {
                paramInt1 = 39;
                }
                U(paramInt1);
                this.ub[paramInt1] = 0;
                this.vb[paramInt1] = ((short)(paramInt2 + 36));
                this.wb[paramInt1] = ((short)(paramInt3 + 36));
                B(paramGraphics, paramInt1);
            }
        }
  
        void A(Graphics paramGraphics)
        {
            this.vb[45] = 95;
            this.wb[45] = 100;
            B(paramGraphics, 45);
        }
  
        void A(Graphics paramGraphics, int paramInt1, int paramInt2)
        {
            this.vb[50] = 0;
            this.wb[50] = ((short)(0 + paramInt1));
            B(paramGraphics, 50);
            this.vb[51] = 0;
            this.wb[51] = ((short)(320 - bA['?'] + paramInt2));
            B(paramGraphics, 51);
        }
  
        void B(Graphics paramGraphics)
        {
            this.vb[52] = 0;
            this.wb[52] = 0;
            B(paramGraphics, 52);
            this.vb[54] = 0;
            this.wb[54] = ((short)(320 - bA['?']));
            B(paramGraphics, 54);
        }
  
        void D(Graphics paramGraphics)
        {
            int i2 = 0;
            int i1 = 240 / bA['?'] + 1;
            while (i2 < i1)
            {
                this.vb[48] = ((short)(i2 * bA['?']));
                this.wb[48] = ((short)(320 - bA['?']));
                B(paramGraphics, 48);
                i2++;
            }
        }
  
        private void A(String paramString, int paramInt)
        {
            if (this.rA[5] > 1) {
                paramInt *= 2;
            } else {
                paramInt = 0;
            }
            this.dA = A(paramString, aB, this.rA[4] - paramInt);
            this.dA = B(this.dA);
        }
  
        public String A(short paramShort)
        {
            if (paramShort == -1)
            {
                paramShort = this.oB;
                if (this.pB != null) {
                D(this.pB.t, this.pB.u);
                }
            }
            else if (paramShort == -2)
            {
                paramShort = this.oB;
            }
            else
            {
                paramShort = D(paramShort);
            }
            return paramShort;
        }
  
        public short B(short paramShort)
        {
            if (paramShort == 0) {
                return 31;
            }
            if (paramShort == 1) {
                return 40;
            }
            if (paramShort == 2) {
                return 41;
            }
            return -1;
        }
  
        private void L(int paramInt)
        {
            if (paramInt == 156)
            {
                this.qA = 156;
                return;
            }
            if (paramInt - 48 > 0) {
                this.qA = (paramInt - 48);
            } else if (paramInt + 36 + 48 < 320) {
                this.qA = (paramInt + 36);
            } else {
                this.qA = 7;
            }
        }
  
        private bool A(short[] paramArrayOfShort)
        {
            this.sc = 0;
            this.pA = true;
            paramArrayOfShort = paramArrayOfShort;
            if (paramArrayOfShort == null) {
                return false;
            }
            String str = A(paramArrayOfShort[2]);
            if ((str == null) || (str.length() == 0)) {
                return false;
            }
            this.kA = B(paramArrayOfShort[1]);
            if (this.tA)
            {
                L(BA(this.jd));
                this.tA = false;
            }
            else
            {
                L(156);
            }
            this.mA = 0;
            A(str, aB, this.kA);
            A(str, 5);
            this.hA = (aB.getHeight() + 1);
            if ((this.rA[5] < this.dA.length) && (this.rA[5] < this.jA))
            {
                paramArrayOfShort = (short)((this.dA.length - this.rA[5]) * this.hA);
                int tmp171_170 = 3;
                short[] tmp171_167 = this.rA;
                tmp171_167[tmp171_170] = ((short)(tmp171_167[tmp171_170] + paramArrayOfShort));
                this.rA[5] = ((short)this.dA.length);
                int tmp194_193 = 1;
                short[] tmp194_190 = this.rA;
                tmp194_190[tmp194_193] = ((short)(tmp194_190[tmp194_193] - paramArrayOfShort));
                if (this.rA[1] < 0)
                {
                int tmp214_213 = 1;
                short[] tmp214_210 = this.rA;
                tmp214_210[tmp214_213] = ((short)(tmp214_210[tmp214_213] - this.rA[1]));
                }
            }
            this.oA = this.rA[5];
            this.cA = new String[this.dA.length];
            this.cA[0] = new String();
            this.nA = (this.oA - 1);
            this.iA = true;
            this.cA = this.dA;
            this.fA = (this.rA[0] + 3 + 0);
            this.eA = 0;
            this.pA = true;
            this.gA = (this.rA[1] + 3 + (this.rA[5] - 1) * this.hA + 2);
            return true;
        }
  
        private String[] A(String[] paramArrayOfString)
        {
            if (paramArrayOfString != null) {
                for (this = 0; this < paramArrayOfString.length; this++) {
                paramArrayOfString[this] = null;
                }
            }
            return null;
        }
  
        private void H()
        {
            this.cA = A(this.cA);
            this.dA = A(this.dA);
            this.iA = true;
        }
  
        public short A(String paramString, Font paramFont)
        {
            int i2 = 0;
            this = 0;
            Townsmen3 localTownsmen31 = 0;
            Townsmen3 localTownsmen32;
            while (i2 < paramString.length())
            {
                if (paramString.charAt(i2) != ' ')
                {
                this = (short)(this + paramFont.charWidth(paramString.charAt(i2)));
                }
                else
                {
                this = (short)(this + paramFont.charWidth(paramString.charAt(i2)));
                if (localTownsmen31 < this) {
                    localTownsmen32 = this;
                }
                this = 0;
                }
                i2++;
            }
            int i1;
            if (localTownsmen32 < this) {
                i1 = this;
            }
            return i1;
        }
  
        public int B(String paramString)
        {
            int i1 = 0;
            this = 0;
            while (i1 < paramString.length())
            {
                if ((paramString.charAt(i1) == ' ') || (i1 == paramString.length() - 1)) {
                this++;
                }
                i1++;
            }
            return this;
        }
  
        public int B(String paramString, Font paramFont)
        {
            int i1 = 0;
            if (paramString == null) {
                return 0;
            }
            for (this = 0; this < paramString.length(); this++) {
                i1 += paramFont.charWidth(paramString.charAt(this));
            }
            return i1;
        }
  
        public int C(String paramString, Font paramFont)
        {
            int i1 = 0;
            if (paramString == null) {
                return 0;
            }
            for (this = 0; this < paramString.length(); this++) {
                if (i1 < paramFont.charWidth(paramString.charAt(this))) {
                i1 = paramFont.charWidth(paramString.charAt(this));
                }
            }
            return i1;
        }
  
        public String[] B(String[] paramArrayOfString)
        {
            String[] arrayOfString = new String[paramArrayOfString.length];
            for (int i1 = 0; i1 < paramArrayOfString.length; i1++)
            {
                this = new StringBuffer();
                append(paramArrayOfString[i1]);
                if (charAt(length() - 1) == ' ') {
                deleteCharAt(length() - 1);
                }
                arrayOfString[i1] = toString();
            }
            return arrayOfString;
        }
  
        public String[] A(String paramString, Font paramFont, int paramInt)
        {
            int i2 = B(paramString, paramFont);
            int i1 = C(paramString, paramFont);
            if ((paramInt < i1) || (i2 == 0))
            {
                this = new String[] { " " };
                return this;
            }
            char[] arrayOfChar = { '\n', ' ', ',', '?', '-', ':', ';', '/', '.', '"', '!' };
            String str3 = "";
            int i10 = 0;
            int i9 = 0;
            int i8 = -1;
            int i7 = 0;
            int i6 = 0;
            int i5 = 0;
            i1 = -1;
            int i4 = 0;
            while (i10 < paramString.length())
            {
                i2 = paramString.charAt(i10);
                String str1;
                if ((i2 == 10) && (i10 != paramString.length() - 1) && (i9 <= paramInt))
                {
                str1 = str3 + paramString.substring(i7, i10);
                str3 = str1 + "\n";
                i6++;
                i7 = i10 + 1;
                if ((paramString.charAt(i10 + 1) == ' ') && (i10 + 1 != paramString.length() - 1))
                {
                    i10 += 2;
                    i7 = i10;
                }
                i8 = -1;
                i9 = paramFont.charWidth(paramString.charAt(i10));
                if ((i9 <= paramInt) && (i1 == -1)) {
                    i4 = i10;
                }
                }
                else
                {
                i9 += paramFont.charWidth(str1);
                if (i1 == -1) {
                    i5 += paramFont.charWidth(str1);
                }
                if ((i9 <= paramInt) && (i1 == -1)) {
                    i4 = i10;
                }
                if ((i9 > paramInt) && (i10 == paramString.length() - 1)) {
                    i1 = i10;
                }
                if ((i9 > paramInt * 2) || ((i9 > paramInt) && (i8 == -1)) || (i1 != -1))
                {
                    if (i8 != -1)
                    {
                    if (i7 == i8)
                    {
                        i4++;
                        str1 = str3 + paramString.substring(i7, i4);
                        i7 = i4;
                        i10 = i4;
                    }
                    else if (i8 < i7)
                    {
                        str1 = str3 + paramString.substring(i8, i7);
                        i8++;
                    }
                    else
                    {
                        if ((i1 != -1) && (paramString.charAt(i1) == ' ') && (i5 - paramFont.charWidth(' ') <= paramInt)) {
                        i5 -= paramFont.charWidth(' ');
                        }
                        if (i5 <= paramInt)
                        {
                        i8++;
                        str1 = str3 + paramString.substring(i7, i8);
                        i7 = i8;
                        i10 = i8;
                        }
                        else
                        {
                        i4++;
                        str1 = str3 + paramString.substring(i7, i4);
                        i7 = i4;
                        i10 = i4;
                        }
                    }
                    i8 = -1;
                    i1 = -1;
                    i4 = 0;
                    i5 = 0;
                    }
                    else
                    {
                    str1 = str3 + paramString.substring(i7, i10);
                    i7 = i10;
                    }
                    if ((paramString.charAt(i10) == ' ') && (i10 != paramString.length() - 1))
                    {
                    i10++;
                    i7 = i10;
                    }
                    i9 = paramFont.charWidth(paramString.charAt(i10));
                    if ((i9 <= paramInt) && (i1 == -1)) {
                    i4 = i10;
                    }
                    str3 = str1 + "\n";
                    i6++;
                }
                }
                int i3 = 0;
                if (i10 != paramString.length() - 1) {
                while (i3 < arrayOfChar.length)
                {
                    if (paramString.charAt(i10) == arrayOfChar[i3]) {
                    if (i9 <= paramInt)
                    {
                        if (paramString.charAt(i10) == '\n') {
                        i8 = i10 + 1;
                        } else {
                        i8 = i10;
                        }
                        i5 = 0;
                        i1 = -1;
                    }
                    else if (i8 != -1)
                    {
                        i1 = i10;
                    }
                    }
                    i3++;
                }
                }
                if (i10 == paramString.length() - 1)
                {
                String str2 = str3 + paramString.substring(i7, i10 + 1);
                i6++;
                str3 = str2 + "\n";
                }
                i10++;
            }
            paramString = new String[i6];
            this.lA = i6;
            i1 = 0;
            paramInt = 0;
            paramFont = 0;
            while (i1 < str3.length())
            {
                this = str3.charAt(i1);
                if ((this == 10) && (paramInt < paramString.length))
                {
                paramString[paramInt] = str3.substring(paramFont, i1);
                paramFont = i1 + 1;
                paramInt++;
                }
                i1++;
            }
            return paramString;
        }
  
        public void E(Graphics paramGraphics)
        {
            F(paramGraphics);
            A(paramGraphics, this.dA);
        }
  
        public short[] A(String paramString, Font paramFont, short paramShort)
        {
            Font localFont2 = this.qA;
            Font localFont1 = B(paramString, paramFont);
            int i1 = paramFont.getHeight();
            String str = 1;
            this.jA = ((short)(138 / (i1 + 1)));
            if ((localFont1 <= 93) || ((B(paramString) == 1) && (localFont1 <= 186)))
            {
                paramFont = A(paramString, paramFont);
            }
            else
            {
                paramFont = 186;
                str = 10;
            }
            paramString = (short)(localFont1 / paramFont);
            if (localFont1 % paramFont > 0) {
                paramString = (short)(paramString + 1);
            }
            if (paramString > this.jA) {
                paramString = this.jA;
            }
            paramString = (short)(paramString * str);
            if (paramString == 1)
            {
                this.rA[4] = ((short)localFont1);
            }
            else if (paramString < 10)
            {
                this.rA[4] = paramFont;
            }
            else
            {
                paramString = (short)(paramString / 10);
                this.rA[4] = 186;
            }
            this.rA[4] = ((short)(this.rA[4] % 2 > 0 ? this.rA[4] + 1 : this.rA[4]));
            paramFont = (short)(paramString * (i1 + 1) - 1 + 8);
            this.rA[3] = ((short)(paramFont - 14));
            if (this.rA[3] < 7)
            {
                this.mA = ((7 - this.rA[3]) / 2);
                this.rA[3] = 7;
            }
            paramFont = (short)(this.rA[3] - 7);
            this.rA[2] = ((short)(this.rA[4] - 8));
            if (this.rA[2] < 0) {
                this.rA[2] = 0;
            }
            if (paramShort == -1)
            {
                this.rA[0] = ((short)((240 - this.rA[4]) / 2 + 0));
                this.rA[1] = ((short)((320 - this.rA[3] - 14) / 2));
            }
            else
            {
                this.rA[0] = 44;
                this.rA[1] = ((short)(localFont2 - paramFont));
            }
            if (this.rA[1] < 0)
            {
                int tmp383_382 = 1;
                short[] tmp383_379 = this.rA;
                tmp383_379[tmp383_382] = ((short)(tmp383_379[tmp383_382] - this.rA[1]));
            }
            this.rA[5] = paramString;
            return this.rA;
        }
  
        public void F(Graphics paramGraphics)
        {
            this.ub[30] = 0;
            this.vb[30] = this.rA[0];
            this.wb[30] = this.rA[1];
            B(paramGraphics, 30);
            for (int i1 = 0; i1 < this.rA[2]; i1++)
            {
                paramGraphics.setClip(this.rA[0] + 7 + i1, this.rA[1], 1, 7);
                paramGraphics.drawImage(this.qb[45], this.rA[0] + i1 + 1, this.rA[1], 20);
                paramGraphics.setClip(this.rA[0] + 7 + i1, this.rA[1] + this.rA[3] + 7, 1, 7);
                paramGraphics.drawImage(this.qb[45], this.rA[0] + 7 + i1, this.rA[1] + this.rA[3] - 7, 20);
            }
            for (i1 = 0; i1 < this.rA[3]; i1++)
            {
                paramGraphics.setClip(this.rA[0], this.rA[1] + 7 + i1, 7, 1);
                paramGraphics.drawImage(this.qb[45], this.rA[0], this.rA[1] + i1 + 1, 20);
                paramGraphics.setClip(this.rA[0] + 7 + this.rA[2], this.rA[1] + 7 + i1, 7, 1);
                paramGraphics.drawImage(this.qb[45], this.rA[0] + 7 + this.rA[2], this.rA[1] + i1 - 7 + 1, 20);
            }
            this.ub[30] = 3;
            this.vb[30] = this.rA[0];
            this.wb[30] = ((short)(this.rA[1] + this.rA[3] + 7));
            B(paramGraphics, 30);
            this.ub[30] = 1;
            this.vb[30] = ((short)(this.rA[0] + 7 + this.rA[2]));
            this.wb[30] = this.rA[1];
            B(paramGraphics, 30);
            this.ub[30] = 2;
            this.vb[30] = ((short)(this.rA[0] + 7 + this.rA[2]));
            this.wb[30] = ((short)(this.rA[1] + this.rA[3] + 7));
            B(paramGraphics, 30);
            paramGraphics.setColor(16777215);
            paramGraphics.fillRect(this.rA[0] + 7, this.rA[1] + 7, this.rA[2], this.rA[3]);
            if ((this.iA) && (this.lA > this.oA)) {
                if (this.nA >= this.lA - 1) {
                A(paramGraphics, 0);
                } else if (this.nA < this.oA) {
                A(paramGraphics, 1);
                } else {
                A(paramGraphics, 2);
                }
            }
        }
  
        private void A(Graphics paramGraphics, int paramInt)
        {
            paramGraphics.setColor(0);
            int i3 = this.rA[0] + 14 + this.rA[2] - 2;
            if ((paramInt == 0) || (paramInt == 2))
            {
                int i2 = this.rA[1] + 7 + 3;
                for (int i1 = 0; i1 < 3; i1++) {
                paramGraphics.drawLine(i3 - 5 + i1 + 0, i2 - i1 + 0, i3 - 1 - i1 + 0, i2 - i1 + 0);
                }
            }
            if ((paramInt == 1) || (paramInt == 2))
            {
                paramInt = this.rA[1] + this.rA[3] + 7 - 3;
                for (this = 0; this < 3; this++) {
                paramGraphics.drawLine(i3 - 5 + this + 0, paramInt + this + 0, i3 - 1 - this + 0, paramInt + this + 0);
                }
            }
        }
  
        public void A(Graphics paramGraphics, String[] paramArrayOfString)
        {
            if (paramArrayOfString == null) {
                return;
            }
            int i2 = 0;
            paramGraphics.setFont(aB);
            paramGraphics.setColor(0);
            if (this.nA == paramArrayOfString.length) {
                this.nA = (paramArrayOfString.length - 1);
            }
            while (i2 < this.oA) {
                if (i2 < paramArrayOfString.length)
                {
                if (this.nA - i2 >= 0)
                {
                    int i1 = (this.rA[4] - B(paramArrayOfString[(this.nA - i2)], aB)) / 2;
                    paramGraphics.drawString(this.cA[(this.nA - i2)], this.fA + i1 + 0, this.mA + this.gA - i2 * this.hA, 20);
                }
                i2++;
                }
            }
        }
  
        public void J()
        {
            this.tA = false;
            this.wA[0] = 0;
            this.wA[1] = 0;
            if (this.qB > 70) {
                this.eb = 15;
            } else {
                this.eb = 6;
            }
            this.fb = this.eb;
            this.hb = -1;
            D localD = null;
            for (int i1 = 0; i1 < this.rd.size(); i1++) {
                if ((this.ed[this.jd][this.id] == ((D)this.rd.elementAt(i1)).f) && (((D)this.rd.elementAt(i1)).d == 3)) {
                localD = (D)this.rd.elementAt(i1);
                }
            }
            A(localD);
            this.zA = 0;
            this.ab = 1;
            this.db = -1;
            this.bb = (this.yA + 10);
            this.uA = B(localD);
            L();
            this.gb = 1;
            this.jb = 0;
            this.ib = 20;
        }
  
        public void A(D paramD)
        {
            int i1 = 0;
            if ((paramD.f.a != 0) && (paramD.f.a != 2) && (paramD.f.a != 3))
            {
                i1 = paramD.f.a * 2 + 1;
                i1 = bA[(this.gd[i1] * 5 + 4)];
            }
            int i4 = 0;
            this.xA = 91;
            this.yA = 0;
            int i3 = E(this.id, this.jd);
            int i2 = BA(this.jd);
            if (i2 + i1 > 58)
            {
                this.yA = (i2 + i1 - 58);
                i4 = 1;
            }
            else if (i2 + 36 + 58 < 320)
            {
                this.yA = (i2 + 36);
                i4 = 1;
            }
            if (i4 != 0)
            {
                if (i3 < 0) {
                this.xA = i3;
                } else if (240 - i3 - 68 < 0) {
                this.xA = (i3 - 0);
                } else {
                this.xA = (i3 + 5);
                }
                return;
            }
            if (i3 > 68)
            {
                this.xA = (i3 - 58);
                i4 = 1;
            }
            if (240 - i3 - 68 > 68)
            {
                this.xA = (i3 + 68);
                i4 = 1;
            }
            if (i4 != 0)
            {
                if (i2 + i1 < 0) {
                this.yA = (i2 - (i2 + i1));
                } else {
                this.yA = (i2 + i1);
                }
                return;
            }
        }
  
        public void K()
        {
            if ((this.vA[this.db] == 50) || (this.vA[this.db] == 61))
            {
                this.zA -= 1;
                if (this.ab != 0) {
                this.ab -= 1;
                }
            }
            if ((this.vA[this.db] == 49) && (this.wA[1] == 1))
            {
                this.zA = 0;
                this.ab = 0;
            }
            this.bb += 30 * this.zA;
            this.db = -1;
            this.fb = this.eb;
        }
  
        public int B(D paramD)
        {
            if ((paramD.f.a == 11) || (paramD.f.a == 12) || (paramD.f.a == 10)) {
                this.wA[1] = ((byte)(paramD.f.c + 2));
            } else {
                this.wA[1] = ((byte)G(1, 4));
            }
            this.wA[0] = ((byte)(paramD.e.c + 1));
            return this.wA[0] + this.wA[1];
        }
  
        public bool L()
        {
            this.vA = new int[this.uA];
            for (int i2 = 0; i2 < this.wA[0]; i2++) {
                this.vA[i2] = 49;
            }
            for (int i1 = i2; i1 < i2 + this.wA[1]; i1++) {
                if (this.ed[this.jd][this.id].x) {
                this.vA[i1] = 61;
                } else {
                this.vA[i1] = 50;
                }
            }
            return (this.wA[0] != 0) && (this.wA[1] != 0);
        }
  
        public void N()
            {
            if ((O()) || (this.db != -1)) {
                return;
            }
            this.tA = true;
            int i1 = G(1, this.uA);
            if (i1 <= this.wA[0])
            {
                this.wA[0] = 1;
                this.wA[1] = 0;
            }
            else
            {
                this.wA[0] = 0;
                this.wA[1] = 1;
            }
            }
  
            public bool O()
            {
            bool bool = false;
            if (this.wA[0] == 0)
            {
                this.hb = 1;
                bool = true;
            }
            else if (this.wA[1] == 0)
            {
                this.hb = 0;
                bool = true;
            }
            return bool;
            }
  
            public void G(Graphics paramGraphics)
            {
            int i1 = E(this.id, this.jd);
            int i2 = BA(this.jd);
            A(paramGraphics, this.id, this.jd, i1, i2, 1);
            int i3 = BA(this.jd) + 36 - 21;
            i2 = i1 + 34 - 12;
            if ((!this.tA) && (this.jb < 2147483637)) {
                this.jb += 1;
            } else {
                this.jb = 0;
            }
            this.jb %= 2;
            if (this.wA[1] != 0)
            {
                i1 = 37;
                if (this.ed[this.jd][this.id].x) {
                i1 = 44;
                }
                this.ub[i1] = ((byte)this.jb);
                this.vb[i1] = ((short)i2);
                this.wb[i1] = ((short)i3);
                B(paramGraphics, i1);
            }
            if (this.wA[0] != 0)
            {
                this.ub[36] = ((byte)this.jb);
                this.vb[36] = ((short)(i2 + 12 + 2));
                this.wb[36] = ((short)i3);
                B(paramGraphics, 36);
            }
            }
  
            public void H(Graphics paramGraphics)
            {
            paramGraphics.setClip(this.xA + 14, this.yA + 10, 30, 30);
            paramGraphics.drawImage(this.qb[this.vA[this.ab]], this.xA + 14, this.cb - 30, 20);
            paramGraphics.drawImage(this.qb[this.vA[this.zA]], this.xA + 14, this.cb, 20);
            }
  
            public void A(int paramInt, byte paramByte)
            {
            int i6 = (byte)(paramByte + 1);
            this.lb = new char[10];
            this.kb = new char[36];
            int i2 = 0;
            Object localObject = null;
            String str;
            while (i2 == 0)
            {
                for (paramByte = 0; paramByte < 10; paramByte++) {
                this.kb[paramByte] = ((char)(paramByte + 48));
                }
                while (paramByte < 36)
                {
                this.kb[paramByte] = ((char)(paramByte + 55));
                paramByte++;
                }
                for (paramByte = this.yB; paramByte.length() < 4; paramByte = paramByte + this.yB) {}
                char[] arrayOfChar2 = paramByte.toCharArray();
                paramByte = G(10, 35);
                int i5 = 0;
                0[(i5++)] = this.kb[paramByte];
                int i4 = paramByte % 8 + 2;
                this.lb[i4] = this.kb[(paramByte - i6 * 3)];
                byte[] arrayOfByte = new byte[4];
                paramByte = 0;
                arrayOfByte[paramByte] = ((byte)G(0, 15));
                char[] arrayOfChar1 = A(arrayOfByte);
                paramByte = 0;
                byte tmp223_222 = paramByte;
                byte[] tmp223_220 = arrayOfByte;
                tmp223_220[tmp223_222] = ((byte)(tmp223_220[tmp223_222] + 1));
                if (arrayOfByte[paramByte] > 8)
                {
                byte tmp241_240 = paramByte;
                byte[] tmp241_238 = arrayOfByte;
                tmp241_238[tmp241_240] = ((byte)(tmp241_238[tmp241_240] - 17));
                }
                paramByte++;
                for (int i1 = 0; i1 < 4; i1++)
                {
                paramByte = arrayOfChar2[i1];
                paramByte %= 36;
                paramByte += arrayOfByte[i1];
                if (paramByte > 35) {
                    paramByte -= 36;
                }
                if (paramByte < 0) {
                    paramByte += 36;
                }
                if (i5 == i4) {
                    i5++;
                }
                this.lb[(i5++)] = this.kb[paramByte];
                if (i5 == i4) {
                    i5++;
                }
                this.lb[(i5++)] = arrayOfChar1[i1];
                }
                str = new String(this.lb).toLowerCase();
                int i3 = 1;
                for (paramByte = 0; paramByte < paramInt; paramByte++) {
                if (this.xB[paramInt].equals(str) == true) {
                    i3 = 0;
                }
                }
            }
            this.xB[paramInt] = str;
            }
  
            public char[] A(byte[] paramArrayOfByte)
            {
            char[] arrayOfChar = new char[4];
            for (int i2 = 0; i2 < 4; i2 += 2)
            {
                int i1 = paramArrayOfByte[i2] | paramArrayOfByte[(i2 + 1)] << 4;
                arrayOfChar[i2] = this.kb[(i1 / 16)];
                arrayOfChar[(i2 + 1)] = this.kb[(i1 % 16)];
            }
            for (this = 0; this < 4; this++) {}
            return arrayOfChar;
            }
  
            public void A(byte paramByte)
            {
            int i1 = B(paramByte);
            if (this.cc.h[9] >= i1)
            {
                this.cc.h[9] -= i1;
                for (int i2 = 0; i2 < 5; i2++)
                {
                if (this.xB[i2] == null)
                {
                    this.xB[i2] = new Byte(paramByte).toString();
                    break;
                }
                if (i2 == 4)
                {
                    for (i1 = 0; i1 < 4; i1++) {
                    this.xB[i1] = this.xB[(i1 + 1)];
                    }
                    this.xB[i2] = new Byte(paramByte).toString();
                }
                }
                KB();
                EA(4);
                H(15, 37);
            }
            }
  
            public int B(byte paramByte)
            {
            if (paramByte == 0) {
                return 100;
            }
            if (paramByte == 1) {
                return 1000;
            }
            return 5000;
            }
  
            public void N(int paramInt)
            {
            this.ob = S(paramInt);
            if (this.ob < 0) {
                return;
            }
            if ((this.ob >= 1) && (this.ob <= 4))
            {
                if (p[1] != 0) {}
            }
            else if (this.ob == 0)
            {
                if ((p[0] != 0) || (p[1] != 0)) {}
            }
            else if (p[0] == 0) {
                return;
            }
            for (paramInt = 0; paramInt < this.nb.length; paramInt++) {
                if (this.mb[paramInt][8] <= this.mb[this.ob][8]) {
                O(paramInt);
                }
            }
            if (this.mb[this.ob][2] == 1)
            {
                R(this.ob);
            }
            else
            {
                Q(this.ob);
                R(this.ob);
            }
            }
  
            public void O(int paramInt)
            {
            paramInt = S(paramInt);
            if (paramInt < 0) {
                return;
            }
            P(paramInt);
            }
  
            private void P(int paramInt)
            {
            switch (this.mb[paramInt][4])
            {
            case 6: 
            case 7: 
            case 10: 
                if (this.nb[paramInt] != null)
                {
                this = (Player)this.nb[paramInt];
                try
                {
                    stop();
                    deallocate();
                }
                catch (Exception localException) {}
                }
                break;
            }
            }
  
            private void Q(int paramInt)
            {
            if (this.nb[paramInt] != null) {
                return;
            }
            Object localObject = null;
            String str = null;
            switch (this.mb[paramInt][4])
            {
            case 6: 
                localObject = ".mid";
                str = "audio/midi";
                break;
            case 7: 
                localObject = ".iml";
                str = "audio/imelody";
                break;
            case 10: 
                localObject = ".amr";
                str = "audio/amr";
            }
            if ((this.nb[paramInt] != null) || (localObject == null) || (str == null)) {
                return;
            }
            localObject = getClass().getResourceAsStream("/" + this.mb[paramInt][1] + (String)localObject);
            try
            {
                this.nb[paramInt] = Manager.createPlayer((InputStream)localObject, str);
                if (this.nb[paramInt] != null) {
                ((Player)this.nb[paramInt]).prefetch();
                }
            }
            catch (Exception localException) {}
            }
  
            private void R(int paramInt)
            {
            switch (this.mb[paramInt][4])
            {
            case 6: 
            case 7: 
            case 10: 
                int i2 = 1;
                if (i2 != 0)
                {
                Player localPlayer2 = (Player)this.nb[paramInt];
                for (i2 = 0; i2 < this.nb.length; i2++) {
                    try
                    {
                    localPlayer2.stop();
                    localPlayer2.deallocate();
                    }
                    catch (Exception localException1) {}
                }
                i2 = 0;
                for (int i1 = 0; i1 < this.nb.length; i1++) {
                    if (localPlayer2.getState() == 400) {
                    i2 = 1;
                    }
                }
                }
                if (this.nb[paramInt] != null)
                {
                Player localPlayer1 = (Player)this.nb[paramInt];
                if (((localPlayer1.getState() == 200) || (localPlayer1.getState() == 300)) && ((this.nb[this.pb] == null) || (((Player)this.nb[this.pb]).getState() != 400)))
                {
                    if (this.mb[paramInt][5] < 0) {
                    localPlayer1.setLoopCount(-1);
                    } else {
                    localPlayer1.setLoopCount(this.mb[paramInt][5] + 1);
                    }
                    try
                    {
                    localPlayer1.start();
                    try
                    {
                        localPlayer1.setMediaTime(0L);
                    }
                    catch (Exception localException2) {}
                    this.pb = paramInt;
                    }
                    catch (Exception localException3) {}
                    if (this.mb[paramInt][3] == 0) {
                    this.nb[paramInt] = null;
                    }
                }
                }
                break;
            }
            }
  
            private int S(int paramInt)
            {
            for (int i1 = 0; i1 < this.mb.length; i1++) {
                if (this.mb[i1][0] == paramInt) {
                return i1;
                }
            }
            return -1;
            }
  
            public short[] A(InputStream paramInputStream) // throws Exception
            {
            byte[] arrayOfByte = new byte[2];
            paramInputStream.read(arrayOfByte, 0, 2);
            Townsmen3 localTownsmen3 = (short)(arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF);
            short[] arrayOfShort = new short[localTownsmen3];
            for (this = 0; this < localTownsmen3; this++)
            {
                paramInputStream.read(arrayOfByte, 0, 2);
                arrayOfShort[this] = ((short)(arrayOfByte[0] << 8 & 0xFF00 | arrayOfByte[1] & 0xFF));
            }
            return arrayOfShort;
            }
  
            public void R()
            {
            for (int i1 = 0; i1 < 64; i1++) {
                this.rb[i1] = true;
            }
            }
  
            public void S()
            {
            if (this.sb) {
                return;
            }
            InputStream localInputStream = null;
            int i4 = -1;
            for (int i1 = 0; i1 < 64; i1++) {
                if (this.rb[i1] == 0)
                {
                this.qb[i1] = null;
                System.gc();
                }
                else if (this.qb[i1] == null)
                {
                i4 = i1;
                }
            }
            System.gc();
            try
            {
                if (i4 >= 0)
                {
                localInputStream = getClass().getResourceAsStream("i");
                if (localInputStream != null)
                {
                    short[] arrayOfShort = A(localInputStream);
                    int i3 = 0;
                    while ((i3 <= i4) && (i3 < arrayOfShort.length))
                    {
                    if ((this.rb[i3] != 0) && (this.qb[i3] == null))
                    {
                        int i2 = arrayOfShort[i3];
                        if (i2 > 0)
                        {
                        byte[] arrayOfByte = new byte[i2];
                        localInputStream.read(arrayOfByte, 0, i2);
                        this.qb[i3] = Image.createImage(arrayOfByte, 0, i2);
                        }
                    }
                    else
                    {
                        localInputStream.skip(arrayOfShort[i3]);
                    }
                    i3++;
                    System.gc();
                    }
                }
                }
            }
            catch (Exception localException2) {}finally
            {
                if (localInputStream != null) {
                try
                {
                    localInputStream.close();
                }
                catch (Exception localException4) {}
                }
            }
            this.sb = true;
            }
  
            public void T() {}
  
            int T(int paramInt)
            {
            paramInt *= 5;
            Image localImage = this.qb[bA[(paramInt + 0)]];
            if (localImage != null)
            {
                this = bA[(paramInt + 1)];
                paramInt = bA[(paramInt + 2)];
                this = localImage.getWidth() / this;
                if (this < 1) {
                this = 1;
                }
                paramInt = localImage.getHeight() / paramInt;
                if (paramInt < 1) {
                paramInt = 1;
                }
                return this * paramInt;
            }
            return 0;
            }
  
            void B(Graphics paramGraphics, int paramInt)
            {
            int i1 = paramInt * 5;
            Image localImage = this.qb[bA[(i1 + 0)]];
            if (localImage != null)
            {
                int i6 = bA[(i1 + 1)];
                Townsmen3 localTownsmen3 = bA[(i1 + 2)];
                int i5 = localImage.getWidth() / i6;
                if (i5 < 1) {
                i5 = 1;
                }
                int i4 = localImage.getHeight() / localTownsmen3;
                if (i4 < 1) {
                i4 = 1;
                }
                int i3 = this.vb[paramInt] + bA[(i1 + 3)];
                int i2 = this.wb[paramInt] + bA[(i1 + 4)];
                i1 = this.ub[paramInt] % i5;
                this = this.ub[paramInt] / i5 % i4;
                paramGraphics.setClip(i3, i2, i6, localTownsmen3);
                paramGraphics.drawImage(localImage, i3 - i1 * i6, i2 - this * localTownsmen3, 20);
                paramGraphics.setClip(0, 0, 240, 320);
            }
            }
  
            public void U()
            {
            for (int i1 = 0; i1 < 55; i1++) {
                this.tb[i1] = true;
            }
            }
  
            public void U(int paramInt)
            {
            if ((paramInt >= 0) && (paramInt < 55))
            {
                int i1 = paramInt * 5;
                i1 = bA[(i1 + 0)];
                this.rb[i1] = true;
                this.tb[paramInt] = true;
            }
            }
  
            public void C(int paramInt1, int paramInt2)
            {
            if (paramInt1 < paramInt2) {
                while (paramInt1 <= paramInt2)
                {
                U(paramInt1);
                paramInt1++;
                }
            }
            }
  
        public Townsmen3()
        {
            try
            {
                this.inputStreamAA = getClass().getResourceAsStream("a");
                objectFieldByteMatrix = makeSbyteMatrix();
                w = A();
                A();
                x = C();
                y = A();
                z = A();
                aa = E();
                ba = C();
                ca = makeSbyteMatrix();
                da = makeSbyteMatrix();
                ea = F();
                fa = C();
                ga = makeSbyteMatrix();
                ha = C();
                A();
                ia = C();
                ja = A();
                ka = A();
                la = A();
                ma = A();
                na = D();
                oa = D();
                pa = A();
                qa = A();
                ra = A();
                sa = A();
                ta = A();
                ua = A();
                va = D();
                wa = A();
                xa = A();
                ya = D();
                za = D();
                try
                {
                this.inputStreamAA.close();
                }
                catch (Exception localException1) {}
                System.out.println("Compiled on 11/07/05 13:34:46");
            }
            catch (Exception localException2) {}finally
            {
                try
                {
                this.inputStreamAA.close();
                }
                catch (Exception localException4) {}
            }
            V();
            b = -1;
            this.n = 200;
            this.e = new Vector();
            this.d = new Vector();
            this.c = new String[1];
            p = A(1, 6);
            if ((p[0] != 0) && (p[1] != 0)) {
                p[1] = false;
            }
            P();
            yb = Font.getFont(64, 0, 0);
            aB = yb;
            TA();
            this.oc = D(31);
            this.pc = D(156);
            W();
        }
  
        public void V()
        {
            if (g == null) {
                openTextsByLocaleName("en");
            }
        }
  
            public void W() {}
  
            private void X()
            {
            Object localObject3 = null;
            C localC = null;
            if (this.l)
            {
                localC = new C(this);
                b = 13;
                localObject3 = E(b);
                ((B)localObject3).A(false, true);
            }
            else if (b != 11)
            {
                localObject3 = E(b);
            }
            int i2;
            Object localObject2;
            switch (b)
            {
            case 6: 
                String[] arrayOfString1 = new String[3];
                arrayOfString1[0] = D(189);
                arrayOfString1[1] = D(6);
                arrayOfString1[2] = D(302);
                this.vc = new ChoiceGroup(D(301), 1, arrayOfString1, null);
                if (p[0] != 0) {
                this.vc.setSelectedIndex(0, true);
                } else if (p[1] != 0) {
                this.vc.setSelectedIndex(1, true);
                } else {
                this.vc.setSelectedIndex(2, true);
                }
                this.t.append(this.vc);
                int i1 = 0;
                i1++;
                i1++;
                i1++;
                i1++;
                String[] arrayOfString2 = new String[4];
                i1 = 0;
                0[(i1++)] = D(56);
                1[(i1++)] = D(138);
                2[(i1++)] = D(1);
                3[(i1++)] = D(4);
                this.wc = new ChoiceGroup(D(153), 2, arrayOfString2, null);
                this.wc.setFitPolicy(1);
                i1 = 0;
                if (p[2] != 0) {
                this.wc.setSelectedIndex(0, true);
                }
                i1++;
                if (p[3] != 0) {
                this.wc.setSelectedIndex(1, true);
                }
                i1++;
                if (p[4] != 0) {
                this.wc.setSelectedIndex(2, true);
                }
                i1++;
                if (p[5] != 0) {
                this.wc.setSelectedIndex(3, true);
                }
                i1++;
                this.t.append(this.wc);
                tmpTernaryOp = arrayOfString2;
                break;
            case 1: 
                try
                {
                this.qb[38] = Image.createImage("/icon38.png");
                arrayOfString2;
                }
                catch (Exception localException1) {}
                ((B)localObject3).A(true, true);
                tmpTernaryOp = arrayOfString2;
                break;
            case 2: 
                try
                {
                this.qb[39] = Image.createImage("/icon39.png");
                arrayOfString2;
                }
                catch (Exception localException2) {}
                N(0);
                ((B)localObject3).A(true, true);
                break;
            case 4: 
                OA();
                this.qb[39] = null;
                this.qb[38] = null;
                this.nc = 0;
                if (this.e != null) {
                this.e.removeAllElements();
                }
                break;
            case 5: 
                Object localObject1 = MB();
                localObject1 = " " + D(68) + ": \n  " + localObject1[0];
                this.t.append((String)localObject1);
                break;
            case 33: 
                JB();
                int i5 = this.dc[1] + 1;
                int i4 = 0;
                if (i5 == 15)
                {
                i5--;
                i4 = 1;
                }
                for (i2 = 0; i2 < i5; i2++)
                {
                this.r.append(D(139) + " " + (i2 + 1), null);
                this.s.addElement(new Integer(23));
                }
                if (i4 != 0)
                {
                this.r.append(D(152), null);
                this.s.addElement(new Integer(23));
                }
                break;
            case 45: 
                LB();
                if (this.yB != null) {
                ((TextField)this.t.get(0)).setString(this.yB);
                } else {
                ((TextField)this.t.get(0)).setString("");
                }
                break;
            case 47: 
                this.t = null;
                System.gc();
                this.t = ((Form)localObject3);
                this.t.append(D(290) + " " + this.yB + "\n");
                for (i2 = 0; i2 < 5; i2++) {
                if (this.xB[i2] == null)
                {
                    this.t.append(" " + (i2 + 1) + ".  -\n");
                }
                else
                {
                    if (this.xB[i2].length() == 1) {
                    A(i2, Byte.parseByte(this.xB[i2]));
                    }
                    this.t.append(" " + (i2 + 1) + ".  " + this.xB[i2] + "\n");
                }
                }
                KB();
                break;
            case 46: 
                this.t = null;
                System.gc();
                this.t = ((Form)localObject3);
                this.t.append(D(27));
                break;
            case 7: 
                break;
            case 30: 
                localObject2 = D(15) + ":\n" + D(16) + "\n\n" + D(25) + ":\n" + D(26) + "\n\n" + D(23) + ":\n" + D(24) + "\n\n" + D(19) + ":\n" + D(20) + "\n\n" + D(11) + ":\n" + D(12) + "\n\n" + D(17) + ":\n" + D(18) + "\n\n" + D(21) + ":\n" + D(22) + "\n\n" + D(7) + ":\n" + D(8) + "\n\n" + D(13) + ":\n" + D(14) + "\n\n" + D(9) + ":\n" + D(10);
                this.t.append((String)localObject2);
                break;
            case 29: 
                this.t.delete(0);
                localObject2 = D(60) + "\n\n" + D(296) + "\n" + D(119) + ", " + D(126) + ": " + D(182) + "\n" + D(120) + ", " + D(128) + ": " + D(183) + "\n" + D(121) + ", " + D(124) + ": " + D(184) + "\n" + D(118) + ", " + D(130) + ": " + D(179) + "\n" + D(123) + ": " + D(185) + "\n" + D(125) + ": " + D(186) + "\n" + D(129) + ": " + D(181) + "\n" + D(131) + ": " + D(180) + "\n" + D(117) + ", " + D(127) + ": " + D(178) + "\n" + D(122) + ": " + D(155) + " / " + D(270) + "\n" + D(133) + ": " + D(86) + "\n" + D(132) + ": " + D(15) + " / " + D(25) + "\n" + D(135) + ": " + D(32) + " / " + D(55) + " / " + D(274) + "\n" + D(136) + ": " + D(157) + "\n\n" + D(280) + "\n" + D(119) + ", " + D(126) + ": " + D(182) + "\n" + D(120) + ", " + D(128) + ": " + D(183) + "\n" + D(117) + ", " + D(135) + ", " + D(127) + ": " + D(178) + "\n" + D(136) + ": " + D(5);
                this.t.append((String)localObject2);
                break;
            case 9: 
                break;
            case 11: 
                LA();
                localObject3 = this.i;
                if ((this.n != 203) && (this.n != 204)) {
                N(G(1, 4));
                }
                break;
            case 8: 
                localObject2 = new String("11/07/05 13:34:46").toCharArray();
                localObject2 = new StringItem(null, "(c) 20" + localObject2[6] + localObject2[7] + ",\n" + D(293) + "\n" + D(2) + "\n" + getAppProperty("MIDlet-Version"));
                this.t.set(0, (Item)localObject2);
            }
            if (localObject3 != null)
            {
                if (((localObject3 instanceof List)) && ((this.f >> 4 & 0xF) == 1) && (((List)localObject3).size() > 0))
                {
                int i3 = H(b);
                if (i3 >= ((List)localObject3).size()) {
                    i3 = ((List)localObject3).size() - 1;
                }
                try
                {
                    ((List)localObject3).setSelectedIndex(i3, true);
                }
                catch (Exception localException3) {}
                }
                if ((this.j != null) && (this.k != null))
                {
                Alert localAlert = new Alert(this.j);
                localAlert.setString(this.k);
                localAlert.setTimeout(-2);
                Display.getDisplay(this).setCurrent(localAlert, (Displayable)localObject3);
                }
                else
                {
                Display.getDisplay(this).setCurrent((Displayable)localObject3);
                }
                this.q = ((Displayable)localObject3);
            }
            if (localC != null) {
                localC.start();
            }
            }
  
            private void Y()
            {
            int i1;
            switch (b)
            {
            case 6: 
                i1 = this.vc.getSelectedIndex();
                if (i1 == 0)
                {
                p[0] = true;
                p[1] = false;
                }
                else if (i1 == 1)
                {
                p[0] = false;
                p[1] = true;
                }
                else
                {
                p[0] = false;
                p[1] = false;
                }
                i1 = 0;
                i1++;
                i1++;
                i1++;
                i1++;
                bool[] arrayOfbool = new bool[4];
                this.wc.getSelectedFlags(arrayOfbool);
                i1 = 0;
                2[arrayOfbool] = 0[(i1++)];
                3[arrayOfbool] = 1[(i1++)];
                4[arrayOfbool] = 2[(i1++)];
                5[arrayOfbool] = 3[(i1++)];
                this.wc = null;
                this.vc = null;
                if (p[0] == 0) {
                Q();
                }
                A(p, 1);
                tmpTernaryOp = p;
                break;
            case 1: 
                this.qb[38] = null;
                System.gc();
                tmpTernaryOp = p;
                break;
            case 2: 
                this.qb[39] = null;
                System.gc();
                tmpTernaryOp = p;
                break;
            case 11: 
                if (this.n == 208) {
                this.pA = true;
                }
                Q();
            }
            switch (this.f & 0xF)
            {
            case 2: 
                if ((this.f >> 4 & 0xF) == 1) {
                B(b, this.r.getSelectedIndex());
                }
                this.r = null;
                this.s = null;
                tmpTernaryOp = p;
                break;
            case 1: 
                if (this.u != null) {
                for (int i2 = 0; i2 < this.u.size(); i2++)
                {
                    i1 = ((Integer)this.u.elementAt(i2)).intValue();
                    this.c[(i1 >> 8)] = ((TextField)this.t.get(i1 & 0xFF)).getString();
                }
                }
                this.u = null;
                this.t = null;
            }
            }
  
            public void C(int paramInt, bool parambool)
            {
            if ((paramInt & 0x3FF) == 550) {
                return;
            }
            if ((paramInt & 0x400) != 0)
            {
                I(b);
                J(paramInt & 0x3FF);
                return;
            }
            if ((paramInt & 0x800) != 0)
            {
                F(paramInt & 0x3FF);
                return;
            }
            if ((paramInt & 0x3FF) == 6)
            {
                B(b, 0);
                this.f &= 0xFF0F;
                J(G());
                return;
            }
            switch (paramInt & 0x3FF)
            {
            case 42: 
                this.c[0] = ((TextField)this.t.get(0)).getString();
                if (this.yB == null) {
                this.yB = this.c[0];
                }
                if (this.c[0].length() == 0)
                {
                J(48);
                this.yB = null;
                }
                else if (this.yB.toUpperCase().equals(this.c[0].toUpperCase()))
                {
                J(47);
                }
                else
                {
                J(46);
                }
                break;
            case 43: 
                this.yB = this.c[0];
                this.xB = new String[5];
                J(47);
                break;
            case 14: 
                if (checkRecordStore(4)) {
                J(32);
                } else {
                J(33);
                }
                break;
            case 19: 
                this.gc = true;
                this.ic = true;
                this.xb = true;
                this.i = null;
                B(11, true);
                break;
            case 23: 
                this.gc = true;
                this.ic = true;
                this.jc = ((byte)this.r.getSelectedIndex());
                this.eB = 0;
                try
                {
                if (this.jc == 14) {
                    AA(this.jc + G(0, 2));
                } else {
                    AA(this.jc);
                }
                }
                catch (Exception localException) {}
                this.i = null;
                B(11, true);
                break;
            case 7: 
                paramInt = new int[2];
                paramInt[0] = 0;
                paramInt[1] = 0;
                checkRecordStore(paramInt);
                J(5);
                break;
            case 38: 
                B(4);
                this.tc = 0;
                J(33);
                break;
            case 1: 
                destroyApp(true);
                break;
            case 2: 
                B(11, true);
                break;
            case 29: 
                if ((this.n != 203) && (this.n != 204)) {
                N(G(1, 4));
                }
                if (this.n == 203) {
                GA(145);
                }
                J(11);
                break;
            case 24: 
                EA(4);
            case 8: 
                T();
                this.i.e = false;
                this.i.d = false;
                this.i = null;
                J(4);
            }
            }
  
            private void Z()
            {
            int[] arrayOfInt;
            switch (this.n)
            {
            case 201: 
                SA();
                if (this.xb) {
                FA(4);
                }
                this.cB = System.currentTimeMillis();
                if ((this.ic) && (this.gc))
                {
                K(202);
                this.xb = false;
                }
                else
                {
                K(202);
                RA();
                }
                break;
            case 209: 
                if (this.o != 204) {
                J();
                }
                this.mc = true;
                this.ec = true;
                this.sc = 0;
                this.pA = true;
                this.qc = false;
                break;
            case 208: 
                OA();
                this.pA = true;
                this.mc = true;
                this.ec = true;
                if (this.o != 204)
                {
                R();
                U();
                NA();
                S();
                }
                this.eC = this.dC.size();
                if (this.dC.size() > 0) {
                A((short[])this.dC.elementAt(0));
                }
                W();
                this.qc = false;
                this.sc = 0;
                this.pA = true;
                if (this.uD)
                {
                this.nA = this.lA;
                this.uD = false;
                }
                break;
            case 202: 
                W();
                this.ec = false;
                if (this.o != 204)
                {
                R();
                U();
                NA();
                S();
                }
                if (this.ic)
                {
                if ((this.gc) && (this.hc))
                {
                    EA(4);
                    this.hc = false;
                }
                this.ic = false;
                }
                break;
            case 204: 
                break;
            case 203: 
                this.sd = new byte[10];
                this.td = 0;
                this.ud = 0;
                this.hD = 0;
                PA();
                this.qc = false;
                this.yc = false;
                break;
            case 205: 
                break;
            case 206: 
                arrayOfInt = MB();
                this.tc += NB();
                if (this.tc > arrayOfInt[0])
                {
                arrayOfInt[0] = this.tc;
                A(arrayOfInt);
                }
                this.kc = true;
                GA(144);
                this.qc = false;
                this.yc = false;
                break;
            case 207: 
                arrayOfInt = MB();
                this.tc += NB();
                if (this.tc > arrayOfInt[0])
                {
                arrayOfInt[0] = this.tc;
                A(arrayOfInt);
                }
                this.kc = false;
                GA(144);
                this.tc = 0;
                this.qc = false;
                this.yc = false;
            }
            }
  
            private void AA()
            {
            switch (this.n)
            {
            case 208: 
                this.yc = false;
                this.qc = false;
                this.h = false;
                H();
                OA();
                W();
                break;
            case 202: 
                OA();
                break;
            case 204: 
                KA();
                break;
            case 203: 
                QA();
            }
            }
  
            public void BA()
            {
            this.fd = ((byte)(this.fd + 1));
            this.fd = ((byte)(this.fd % 3));
            switch (b)
            {
            case 11: 
                switch (this.n)
                {
                case 209: 
                if (this.h)
                {
                    this.h = false;
                    K(204);
                    return;
                }
                M();
                if (this.db == -1) {
                    EA();
                }
                break;
                case 208: 
                if (!this.iA) {
                    I();
                }
                GA();
                break;
                case 202: 
                int i2 = 1;
                if (this.qc) {
                    i2 = 100;
                }
                for (int i1 = 0; i1 < i2; i1++)
                {
                    if (this.cc.h[9] > 99999) {
                    this.cc.h[9] = 99999;
                    }
                    if (!this.dC.isEmpty()) {
                    K(208);
                    }
                    if (this.h)
                    {
                    this.h = false;
                    GA(145);
                    return;
                    }
                    VA();
                    CC();
                    PB();
                    AC();
                    if (p[5] != 0) {
                    OB();
                    }
                    if (!this.yc) {
                    HA();
                    }
                    if (p[2] != 0)
                    {
                    long l1 = System.currentTimeMillis() - this.cB;
                    if ((l1 > 0L) && (l1 < 5000L)) {
                        this.dB = true;
                    } else {
                        this.dB = false;
                    }
                    }
                    switch (this.je)
                    {
                    case 0: 
                    K(205);
                    this.je = -1;
                    break;
                    case 1: 
                    this.je = -1;
                    break;
                    case 2: 
                    this.je = -1;
                    }
                    if (((this.fB + 1) % 10000 == 1) && (this.fB + 1 != 1))
                    {
                    if (!this.uc)
                    {
                        H(0, 289);
                        this.yc = true;
                        this.uc = true;
                    }
                    }
                    else if ((this.fB + 1) % 10000 == 0) {
                    this.uc = false;
                    }
                    if (this.fc == 0)
                    {
                    this.fc = YA();
                    BB();
                    }
                    else if ((this.fc != 0) && (this.dC.size() == 0))
                    {
                    if (this.fc == 2) {
                        K(206);
                    } else {
                        K(207);
                    }
                    }
                    if (this.n != 202) {
                    i1 = i2;
                    }
                }
                if (this.rc <= this.fB - 5)
                {
                    if (this.qc) {
                    N(20);
                    }
                    this.qc = false;
                    this.yc = false;
                }
                break;
                case 203: 
                if (this.cc.h[9] > 99999) {
                    this.cc.h[9] = 99999;
                }
                if (this.h) {
                    this.h = false;
                }
                if ((this.cD == 13) && (this.eD == 111)) {
                    IA();
                }
                JA();
                break;
                case 204: 
                if (this.bB == 48)
                {
                    this.yc = false;
                    K(this.o);
                }
                this.bB = 0;
                }
                break;
            }
            }
  
            public void V(int paramInt)
            {
                switch (b)
                {
                case 11: 
                    if ((this.yc) && (this.n != 209) && (this.n != 208) && (this.n != 204)) {
                        return;
                    }
                    if (paramInt == -7)
                    {
                        if ((this.n == 203) && (this.eD == 144)) {
                                return;
                    }
                    if ((this.n == 203) && (this.eD != 145))
                    {
                        this.bB = paramInt;
                    }
                    else if (this.fc == 0)
                    {
                        this.i.e = false;
                        J(12);
                    }
                    return;
                    }
                    this.bB = paramInt;
                }
            }
  
            public void W(int paramInt) {}
  
            public void CA()
            {
            switch (this.bB)
            {
            case -3: 
            case 52: 
                if ((this.jd & 0x1) > 0)
                {
                if (this.jd > 0) {
                    this.jd -= 1;
                }
                }
                else if ((this.id > 0) && (this.jd < this.wC - 1))
                {
                this.id -= 1;
                this.jd += 1;
                }
                break;
            case 49: 
                if ((this.jd & 0x1) > 0)
                {
                if (this.jd > 0) {
                    this.jd -= 1;
                }
                }
                else if ((this.id > 0) && (this.jd > 0))
                {
                this.id -= 1;
                this.jd -= 1;
                }
                break;
            case -1: 
            case 50: 
                if (this.jd > 1) {
                this.jd -= 2;
                }
                break;
            case 51: 
                if ((this.jd & 0x1) > 0)
                {
                if ((this.id < this.vC - 1) && (this.jd > 0))
                {
                    this.id += 1;
                    this.jd -= 1;
                }
                }
                else if (this.jd > 0) {
                this.jd -= 1;
                }
                break;
            case -4: 
            case 54: 
                if ((this.jd & 0x1) > 0)
                {
                if ((this.id < this.vC - 1) && (this.jd > 0))
                {
                    this.id += 1;
                    this.jd -= 1;
                }
                }
                else if (this.jd < this.wC - 1) {
                this.jd += 1;
                }
                break;
            case 57: 
                if ((this.jd & 0x1) > 0)
                {
                if ((this.id < this.vC - 1) && (this.jd < this.wC - 1))
                {
                    this.id += 1;
                    this.jd += 1;
                }
                }
                else if (this.jd < this.wC - 1) {
                this.jd += 1;
                }
                break;
            case -2: 
            case 56: 
                if (this.jd < this.wC - 2) {
                this.jd += 2;
                }
                break;
            case 55: 
                if ((this.jd & 0x1) > 0)
                {
                if (this.jd < this.wC - 1) {
                    this.jd += 1;
                }
                }
                else if ((this.id > 0) && (this.jd < this.wC - 1))
                {
                this.id -= 1;
                this.jd += 1;
                }
                break;
            }
            }
  
            public void DA()
            {
            switch (this.bB)
            {
            case -3: 
            case 52: 
                if (this.id > 0) {
                this.id -= 1;
                }
                break;
            case 49: 
                if ((this.jd & 0x1) == 0)
                {
                if ((this.id > 0) && (this.jd > 0))
                {
                    this.id -= 1;
                    this.jd -= 1;
                }
                }
                else if (this.jd > 0) {
                this.jd -= 1;
                }
                break;
            case -1: 
            case 50: 
                if (this.jd > 1) {
                this.jd -= 2;
                }
                break;
            case 51: 
                if ((this.jd & 0x1) > 0)
                {
                if ((this.id < this.vC - 1) && (this.jd > 0))
                {
                    this.id += 1;
                    this.jd -= 1;
                }
                }
                else if (this.jd > 0) {
                this.jd -= 1;
                }
                break;
            case -4: 
            case 54: 
                if (this.id < this.vC - 1) {
                this.id += 1;
                }
                break;
            case 57: 
                if ((this.jd & 0x1) > 0)
                {
                if ((this.id < this.vC - 1) && (this.jd < this.wC - 1))
                {
                    this.id += 1;
                    this.jd += 1;
                }
                }
                else if (this.jd < this.wC - 1) {
                this.jd += 1;
                }
                break;
            case -2: 
            case 56: 
                if (this.jd < this.wC - 2) {
                this.jd += 2;
                }
                break;
            case 55: 
                if ((this.jd & 0x1) == 0)
                {
                if ((this.id > 0) && (this.jd < this.wC - 1))
                {
                    this.id -= 1;
                    this.jd += 1;
                }
                }
                else if (this.jd < this.wC - 1) {
                this.jd += 1;
                }
                break;
            }
            }
  
            public void EA()
            {
            switch (this.bB)
            {
            case -6: 
                N();
            case -5: 
            case 53: 
                FA();
                break;
            case 48: 
                this.h = true;
            }
            this.bB = 0;
            }
  
            public void FA()
            {
            if (this.tA)
            {
                if (!O())
                {
                this.tA = false;
                this.ib = G(1, 20);
                }
                else
                {
                D localD = null;
                int i2 = 0;
                for (int i1 = 0; i1 < this.rd.size(); i1++) {
                    if ((this.ed[this.jd][this.id] == ((D)this.rd.elementAt(i1)).f) && (((D)this.rd.elementAt(i1)).d == 3))
                    {
                    localD = (D)this.rd.elementAt(i1);
                    i2 = i1;
                    }
                }
                short[] arrayOfShort = new short[3];
                arrayOfShort[0] = 1;
                if (this.hb == 0)
                {
                    arrayOfShort[1] = 0;
                    arrayOfShort[2] = 188;
                    if (!localD.f.x) {
                    if (localD.f.a >= 6) {
                        this.qB = ((byte)(this.qB - 10));
                    } else {
                        this.qB = ((byte)(this.qB - 5));
                    }
                    }
                    if ((localD.f.a == 11) || (localD.f.a == 12) || (localD.f.a == 10))
                    {
                    A(localD.f, false);
                    localD.f.i = 1;
                    A(10, 8, localD.f.t, localD.f.u, 0, -24, 48, 36, 0, 6, 0, 2);
                    }
                    if ((localD.f.a < 6) || ((localD.f.a >= 6) && (localD.f.a != 11) && (localD.f.a != 12) && (localD.f.a != 10)) || ((localD.f.a == 10) && (!localD.f.x)))
                    {
                    localD.f.w = false;
                    localD.f.x = false;
                    }
                    localD.ba = true;
                    localD.aa = true;
                    localD.H();
                    this.tB += 1;
                }
                else if (this.hb == 1)
                {
                    if (!localD.f.x) {
                    if (localD.f.a >= 6) {
                        this.qB = ((byte)(this.qB - 5));
                    } else {
                        this.qB = ((byte)(this.qB - 2));
                    }
                    }
                    arrayOfShort[1] = 0;
                    arrayOfShort[2] = 187;
                    this.rd.removeElementAt(i2);
                    this.uB += 1;
                }
                if (this.qB < 0) {
                    this.qB = 0;
                }
                XB();
                this.dC.addElement(arrayOfShort);
                K(208);
                }
            }
            else if (this.ib < 0)
            {
                this.db = this.zA;
                this.gb = 1;
            }
            }
  
            public void GA()
            {
            switch (this.bB)
            {
            case -1: 
            case 50: 
                if (!this.iA) {
                return;
                }
                if (this.nA >= this.oA)
                {
                this.nA -= 1;
                this.pA = true;
                }
                break;
            case -2: 
            case 56: 
                if (!this.iA) {
                return;
                }
                if (this.nA < this.lA)
                {
                this.nA += 1;
                this.pA = true;
                }
                break;
            case -5: 
            case 53: 
                if ((this.eC > 1) || (!this.iA))
                {
                if (!this.iA)
                {
                    this.nA = (this.oA - 1);
                    this.iA = true;
                    this.pA = true;
                    this.cA = this.dA;
                }
                else
                {
                    this.eC -= 1;
                    A((short[])this.dC.elementAt(this.dC.size() - this.eC));
                    W();
                }
                }
                else
                {
                this.dC = new Vector();
                this.h = false;
                K(202);
                }
                break;
            }
            this.bB = 0;
            }
  
            public void HA()
            {
            if ((this.qc) && (this.bB == -6))
            {
                N(20);
                this.qc = false;
                this.yc = false;
                this.bB = 0;
            }
            if (this.yc) {
                return;
            }
            if (p[4] != 0) {
                DA();
            } else {
                CA();
            }
            switch (this.bB)
            {
            case -5: 
            case 53: 
                this.cD = 0;
                GA(this.ed[this.jd][this.id].a);
                break;
            case 48: 
                this.h = true;
                break;
            case 35: 
                A localA = DA(11);
                if ((localA != null) && (this.ed[this.jd][this.id].a == 13)) {
                D(localA.t, localA.u);
                } else {
                D(this.cc.t, this.cc.u);
                }
                break;
            case 42: 
                GA(143);
                break;
            case -6: 
                this.ee = -1;
                for (int i1 = 0; i1 < 3; i1++) {
                if (this.ce[i1][1] > 0)
                {
                    this.ee = i1;
                    break;
                }
                }
                if (this.ee != -1)
                {
                this.ce[this.ee][1] = 0;
                N(6);
                this.oB = (D(31) + " " + (this.ce[this.ee][2] + 1) + ":\n" + D(this.ce[this.ee][7]));
                if (this.ce[this.ee][7] == 40) {
                    this.oB = (this.oB + "\n" + D(ya[this.ce[this.ee][3]]) + " " + this.ce[this.ee][4]);
                }
                if (this.de[this.ee] != null)
                {
                    D(this.de[this.ee].t, this.de[this.ee].u);
                    H(0, -2);
                    this.yc = true;
                }
                }
                else
                {
                N(19);
                this.qc = true;
                this.rc = this.fB;
                }
                this.yc = true;
            }
            HB();
            this.bB = 0;
            }
  
            public void IA()
            {
            int i1;
            switch (this.bB)
            {
            case 48: 
                for (i1 = 0; i1 < this.zc.length; i1++) {
                this.zc[i1] = false;
                }
                this.aC = 0;
                this.zc[this.aC] = true;
                this.aC += 1;
                this.bB = 0;
                break;
            case 55: 
                if ((this.aC != 0) && (this.zc[(this.aC - 1)] != 0) && ((this.aC == 1) || (this.aC == 4) || (this.aC == 5)))
                {
                this.zc[this.aC] = true;
                this.aC += 1;
                this.bB = 0;
                }
                else
                {
                for (i1 = 0; i1 < this.zc.length; i1++) {
                    this.zc[i1] = false;
                }
                this.aC = 0;
                }
                break;
            case 54: 
                if ((this.aC != 0) && (this.zc[(this.aC - 1)] != 0) && ((this.aC == 2) || (this.aC == 3)))
                {
                this.zc[this.aC] = true;
                this.aC += 1;
                this.bB = 0;
                }
                else
                {
                for (i1 = 0; i1 < this.zc.length; i1++) {
                    this.zc[i1] = false;
                }
                this.aC = 0;
                }
                break;
            case 57: 
                if ((this.aC != 0) && (this.zc[(this.aC - 1)] != 0))
                {
                this.dc[1] = 14;
                IB();
                for (i1 = 0; i1 < this.zc.length; i1++) {
                    this.zc[i1] = false;
                }
                this.aC = 0;
                }
                break;
            default: 
                if (this.bB != 0)
                {
                for (i1 = 0; i1 < this.zc.length; i1++) {
                    this.zc[i1] = false;
                }
                this.aC = 0;
                }
                break;
            }
            }
  
            public void JA()
            {
            int i1;
            switch (this.bB)
            {
            case -7: 
                if (this.eD != 115) {
                if (this.xd[1] == 100)
                {
                    MA();
                }
                else
                {
                    this.vd = true;
                    this.cD = this.eD;
                    if (this.td > 0) {
                    this.td = ((byte)(this.td - 1));
                    }
                    this.ud = this.sd[this.td];
                    GA(this.xd[1]);
                }
                }
                break;
            case -3: 
            case 52: 
                if (this.ud <= 0) {
                this.ud = (this.xd.length - 2);
                } else {
                this.ud -= 2;
                }
                break;
            case -4: 
            case 54: 
                if (this.ud >= this.xd.length - 2) {
                this.ud = 0;
                } else {
                this.ud += 2;
                }
                break;
            case -6: 
            case -5: 
            case 53: 
                this.bB = 0;
                if (this.ud == 0) {
                this.vd = true;
                } else {
                this.vd = false;
                }
                if (this.xd[(this.ud + 1)] == 100)
                {
                MA();
                }
                else if ((this.xd[(this.ud + 1)] == 107) || (this.xd[(this.ud + 1)] == 106))
                {
                GA(this.xd[(this.ud + 1)]);
                }
                else if ((this.xd[(this.ud + 1)] != 111) && ((this.vd) || (this.xd[(this.ud + 1)] == this.ed[this.jd][this.id].a) || (this.eD == 178) || ((this.eD >= 168) && (this.eD <= 177)) || ((this.eD >= 126) && (this.eD <= 138))))
                {
                this.cD = this.eD;
                GA(this.xd[(this.ud + 1)]);
                if (this.td > 0)
                {
                    this.td = ((byte)(this.td - 1));
                    if ((this.cD == 178) && (this.ud != 0)) {
                    this.td = ((byte)(this.td - 1));
                    }
                }
                this.ud = this.sd[this.td];
                if (this.xd.length - 1 < this.ud) {
                    this.ud = 0;
                }
                }
                else
                {
                this.cD = this.eD;
                GA(this.xd[(this.ud + 1)]);
                this.sd[this.td] = ((byte)this.ud);
                this.td = ((byte)(this.td + 1));
                this.ud = 0;
                }
                break;
            case 42: 
                if (this.eD == 143) {
                K(202);
                }
                break;
            case 48: 
                if (this.eD == 145)
                {
                N(G(1, 4));
                K(202);
                }
                break;
            case -1: 
            case 50: 
                i1 = 0;
            case -2: 
            case 56: 
                while (i1 < this.xd.length) {
                if (this.xd[(i1 + 1)] == 107)
                {
                    GA(this.xd[(i1 + 1)]);
                }
                else
                {
                    i1 += 2;
                    continue;
                    for (i1 = 0; i1 < this.xd.length; i1 += 2) {
                    if (this.xd[(i1 + 1)] == 106)
                    {
                        GA(this.xd[(i1 + 1)]);
                        break;
                    }
                    }
                }
                }
            }
            this.bB = 0;
            }
  
            private void KA()
            {
            if (this.mc) {
                N(G(1, 4));
            }
            this.mc = false;
            }
  
            public void LA()
            {
            W();
            this.gD = ((320 - bA[92] - 56) / yb.getHeight());
            if (this.i == null)
            {
                this.mc = false;
                this.nc = 0;
                this.i = ((B)E(b));
                this.i.A(true, true);
                K(201);
            }
            else
            {
                this.i.e = true;
            }
            this.h = false;
            this.sc = 0;
            this.pA = true;
            }
  
            public void MA()
            {
            if (this.eD == 144)
            {
                T();
                this.i.e = false;
                this.i.d = false;
                this.i = null;
                if ((this.kc) && (this.jc < 14))
                {
                this.gc = true;
                this.ic = true;
                this.rB = true;
                this.jc = ((byte)(this.jc + 1));
                this.eB = 0;
                try
                {
                    AA(this.jc);
                }
                catch (Exception localException) {}
                if (this.dc[1] < this.jc)
                {
                    this.dc[1] = this.jc;
                    IB();
                }
                this.i = null;
                this.hc = true;
                B(11, true);
                }
                else
                {
                J(4);
                }
            }
            else if (this.eD == 141)
            {
                for (int i1 = 0; i1 < this.ge.length; i1++) {
                if (this.ge[i1] > 0)
                {
                    if (this.vB == 1)
                    {
                    this.he += 1;
                    break;
                    }
                    this.ie += 1;
                    break;
                }
                }
                for (int i2 = 0; i2 < this.cc.h.length; i2++) {
                if (i2 == 9)
                {
                    this.cc.h[9] += this.ge[i2];
                }
                else
                {
                    i1 = ba[7][i2][this.cc.c];
                    i1 -= this.cc.h[i2];
                    if (i1 > 0)
                    {
                    if (i1 <= this.ge[i2]) {
                        this.ge[i2] = i1;
                    }
                    this.cc.h[i2] += this.ge[i2];
                    }
                }
                }
                K(202);
            }
            else
            {
                if ((this.wd == 11) && (this.ee != -1)) {}
                K(202);
                if (!this.dC.isEmpty()) {
                K(208);
                }
                if (this.eD == 145) {
                N(G(1, 4));
                }
            }
            this.cD = 0;
            this.eD = -1;
            }
  
            public void NA()
            {
            C(0, 16);
            U(18);
            U(20);
            U(21);
            U(22);
            U(23);
            U(25);
            U(26);
            U(27);
            U(28);
            U(29);
            U(32);
            U(30);
            U(31);
            U(38);
            U(39);
            U(42);
            U(43);
            U(45);
            U(40);
            U(41);
            U(49);
            U(33);
            U(34);
            U(35);
            U(36);
            U(37);
            U(38);
            U(39);
            U(44);
            U(46);
            U(47);
            }
  
            public void OA() {}
  
            public void PA()
            {
            U(17);
            U(23);
            U(18);
            U(19);
            U(24);
            U(0);
            U(45);
            U(47);
            U(39);
            U(50);
            U(51);
            U(52);
            U(53);
            U(54);
            U(48);
            }
  
            public void QA() {}
  
            public void A(A paramA)
            {
            switch (paramA.a)
            {
            case 6: 
            case 7: 
            case 15: 
                paramA.q = new D(this, 1, paramA, this.cc);
            case 13: 
                paramA.p = new D(this, 0, paramA, null);
                break;
            case 8: 
            case 9: 
            case 10: 
                if ((paramA.a != 10) || (!paramA.x)) {
                paramA.q = new D(this, 1, paramA, this.cc);
                }
                break;
            }
            }
  
            public void RA()
            {
            int i2 = this.wC;
            for (;;)
            {
                i2--;
                if (i2 < 0) {
                break;
                }
                int i1 = this.vC;
                for (;;)
                {
                i1--;
                if (i1 < 0) {
                    break;
                }
                A localA = this.ed[i2][i1];
                if (localA.a >= 6) {
                    A(localA);
                }
                }
            }
            }
  
            public void B(A paramA)
            {
            paramA.a = 0;
            if ((paramA.a >= 0) && (paramA.a < 6)) {
                paramA.b = ((byte)G(0, 3));
            }
            paramA.c = 0;
            paramA.d = 0;
            for (this = 0; this < 3; this++)
            {
                paramA.f[this] = 0;
                paramA.g[this] = 0;
            }
            this = 14;
            for (;;)
            {
                this--;
                if (this < 0) {
                break;
                }
                paramA.h[this] = 0;
            }
            paramA.i = 0;
            paramA.j = 0;
            paramA.k = 0;
            paramA.l = 0;
            paramA.m = 0;
            if (paramA.p != null)
            {
                paramA.p.A(true);
                paramA.p = null;
            }
            if (paramA.q != null)
            {
                paramA.q.A(true);
                paramA.q = null;
            }
            }
  
            private void SA()
            {
            this.he = 0;
            this.ie = 0;
            this.md = 0;
            this.ke.removeAllElements();
            this.eB = 0;
            this.fB = 0;
            BC();
            this.ee = -1;
            this.hB = false;
            this.gB = false;
            this.lB = false;
            this.nB = true;
            this.iB = -1;
            this.jB = -1;
            this.kB = -1;
            this.mB = true;
            if (!this.rB)
            {
                this.qB = 50;
                this.vB = 0;
            }
            this.rB = false;
            this.sB = 0;
            this.tB = 0;
            this.uB = 0;
            this.wB = 0;
            this.xD = 0;
            this.fC = 0;
            this.gC = 0;
            this.yc = false;
            this.qc = false;
            this.oB = null;
            this.pB = null;
            this.hC = new byte[8][2];
            this.iC = 0;
            this.dC = new Vector();
            this.od = new Vector();
            this.rd = new Vector();
            this.fc = 0;
            this.zB = true;
            this.ac = false;
            this.qd = 1000;
            }
  
            private void TA()
            {
            this.bC = new short[8][20];
            this.cC = new short[64][6];
            UA();
            }
  
            private void UA()
            {
            int i1 = 8;
            for (;;)
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                this.bC[i1][0] = -1;
            }
            i1 = 64;
            for (;;)
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                this.cC[i1][0] = -1;
            }
            }
  
            private void X(int paramInt)
            {
            if (this.cC[paramInt][0] != -1) {
                if (this.cC[paramInt][0] > 0)
                {
                int tmp30_29 = 0;
                short[] tmp30_28 = this.cC[paramInt];
                tmp30_28[tmp30_29] = ((short)(tmp30_28[tmp30_29] - 1));
                }
                else if (this.cC[paramInt][5] > 0)
                {
                int tmp57_56 = 5;
                short[] tmp57_55 = this.cC[paramInt];
                tmp57_55[tmp57_56] = ((short)(tmp57_55[tmp57_56] - 1));
                }
                else if (this.cC[paramInt][3] == 0)
                {
                this.cC[paramInt][0] = -1;
                }
                else
                {
                int tmp96_95 = 3;
                short[] tmp96_94 = this.cC[paramInt];
                tmp96_94[tmp96_95] = ((short)(tmp96_94[tmp96_95] - 1));
                this.cC[paramInt][5] = this.cC[paramInt][4];
                }
            }
            }
  
            private void A(int paramInt1, int paramInt2, int paramInt3, int paramInt4, int paramInt5, int paramInt6, int paramInt7, int paramInt8, int paramInt9)
            {
            this.cC[paramInt1][0] = ((short)G(paramInt6, paramInt7));
            this.cC[paramInt1][1] = ((short)(paramInt2 + G(0, paramInt4)));
            this.cC[paramInt1][2] = ((short)(paramInt3 + G(0, paramInt5)));
            this.cC[paramInt1][3] = 2;
            this.cC[paramInt1][4] = ((short)G(paramInt8, paramInt9));
            this.cC[paramInt1][5] = this.cC[paramInt1][4];
            }
  
            private void VA()
            {
            int i4 = 8;
            for (;;)
            {
                i4--;
                if (i4 < 0) {
                break;
                }
                if (this.bC[i4][0] != -1)
                {
                int i3 = 0;
                for (int i2 = 0; i2 < this.bC[i4][1]; i2++)
                {
                    int i1 = this.bC[i4][(12 + i2)];
                    if (i1 == -1) {
                    i3++;
                    } else if (this.cC[i1][0] != -1) {
                    X(i1);
                    } else if (this.bC[i4][0] > 0) {
                    A(i1, this.bC[i4][4], this.bC[i4][5], this.bC[i4][6], this.bC[i4][7], this.bC[i4][8], this.bC[i4][9], this.bC[i4][10], this.bC[i4][11]);
                    } else {
                    this.bC[i4][(12 + i2)] = -1;
                    }
                }
                if (this.bC[i4][0] > 0)
                {
                    int tmp223_222 = 0;
                    short[] tmp223_221 = this.bC[i4];
                    tmp223_221[tmp223_222] = ((short)(tmp223_221[tmp223_222] - 1));
                }
                else if (i3 == this.bC[i4][1])
                {
                    this.bC[i4][0] = -1;
                    Z(i4);
                }
                }
            }
            }
  
            private void C(Graphics paramGraphics, int paramInt)
            {
            if (this.bC[paramInt][0] != -1) {
                for (int i4 = 0; i4 < this.bC[paramInt][1]; i4++)
                {
                int i3 = this.bC[paramInt][(12 + i4)];
                if ((i3 != -1) && (this.cC[i3][0] != -1) && (this.cC[i3][0] == 0))
                {
                    int i2 = E(this.bC[paramInt][2], this.bC[paramInt][3]) + this.cC[i3][1];
                    int i1 = BA(this.bC[paramInt][3]) + this.cC[i3][2];
                    this.ub[28] = ((byte)this.cC[i3][3]);
                    this.vb[28] = ((short)i2);
                    this.wb[28] = ((short)i1);
                    B(paramGraphics, 28);
                }
                }
            }
            }
  
            public void A(int paramInt1, int paramInt2, int paramInt3, int paramInt4, int paramInt5, int paramInt6, int paramInt7, int paramInt8, int paramInt9, int paramInt10, int paramInt11, int paramInt12)
            {
            int i1 = 8;
            paramInt2 = paramInt2 < 8 ? paramInt2 : 8;
            do
            {
                i1--;
                if (i1 < 0) {
                break;
                }
            } while (this.bC[i1][0] != -1);
            this.bC[i1][1] = 0;
            this.bC[i1][2] = ((short)paramInt3);
            this.bC[i1][3] = ((short)paramInt4);
            this.bC[i1][5] = ((short)paramInt5);
            this.bC[i1][5] = ((short)paramInt6);
            this.bC[i1][6] = ((short)paramInt7);
            this.bC[i1][7] = ((short)paramInt8);
            this.bC[i1][8] = ((short)paramInt9);
            this.bC[i1][9] = ((short)paramInt10);
            this.bC[i1][10] = ((short)paramInt11);
            this.bC[i1][11] = ((short)paramInt12);
            paramInt4 = 0;
            for (paramInt3 = 0; (paramInt3 < 64) && (paramInt4 < paramInt2); paramInt3 = (short)(paramInt3 + 1)) {
                if (this.cC[paramInt3][0] == -1)
                {
                A(paramInt3, paramInt5, paramInt6, paramInt7, paramInt8, paramInt9, paramInt10, paramInt11, paramInt12);
                this.bC[i1][(12 + paramInt4)] = paramInt3;
                paramInt4 = (short)(paramInt4 + 1);
                }
            }
            if (paramInt4 != 0)
            {
                this.bC[i1][0] = ((short)paramInt1);
                this.bC[i1][1] = paramInt4;
                Y(i1);
            }
            while (paramInt4 < 8)
            {
                this.bC[i1][(12 + paramInt4)] = -1;
                paramInt4 = (short)(paramInt4 + 1);
            }
            }
  
            private void Y(int paramInt)
            {
            A localA = this.ed[this.bC[paramInt][3]][this.bC[paramInt][2]];
            this = 8;
            do
            {
                this--;
                if (this < 0) {
                break;
                }
            } while (localA.r[this] != -1);
            localA.r[this] = ((byte)paramInt);
            A tmp52_51 = localA;
            tmp52_51.s = ((byte)(tmp52_51.s + 1));
            }
  
            private void Z(int paramInt)
            {
            if ((this.bC[paramInt][3] >= 0) && (this.bC[paramInt][3] < this.ed.length) && (this.bC[paramInt][2] > 0) && (this.bC[paramInt][2] < this.ed[0].length))
            {
                A localA = this.ed[this.bC[paramInt][3]][this.bC[paramInt][2]];
                this = 8;
                do
                {
                this--;
                if (this < 0) {
                    break;
                }
                } while (localA.r[this] != paramInt);
                localA.r[this] = -1;
                A tmp107_106 = localA;
                tmp107_106.s = ((byte)(tmp107_106.s - 1));
            }
            }
  
            public void WA()
            {
            switch (b)
            {
            case 1: 
                this.xc.setColor(16777215);
                this.xc.fillRect(0, 0, 240, 320);
                if (this.qb[38] != null) {
                this.xc.drawImage(this.qb[38], 120, 160, 3);
                }
                break;
            case 2: 
                this.xc.setColor(2040832);
                this.xc.fillRect(0, 0, 240, 320);
                if (this.qb[39] != null) {
                this.xc.drawImage(this.qb[39], 120, 160, 3);
                }
                break;
            case 11: 
                J(this.xc);
                break;
            case 13: 
                String str = this.pc;
                this.xc.setColor(0);
                this.xc.fillRect(0, 0, 240, 320);
                this.xc.setColor(16777215);
                this.xc.drawString(str, 120 - Font.getDefaultFont().stringWidth(str) / 2, 160 - Font.getDefaultFont().getHeight() / 2, 20);
            }
            }
  
            private void J(Graphics paramGraphics)
            {
            switch (b)
            {
            case 11: 
                paramGraphics.setFont(yb);
                int i2;
                int i1;
                switch (this.n)
                {
                case 205: 
                paramGraphics.setColor(0);
                paramGraphics.fillRect(0, 0, 240, 320);
                M(paramGraphics);
                break;
                case 209: 
                if (this.sc < 5)
                {
                    paramGraphics.setColor(0);
                    paramGraphics.fillRect(0, 0, 240, 320);
                    M(paramGraphics);
                    K(paramGraphics);
                    this.sc += 1;
                }
                I(paramGraphics);
                break;
                case 208: 
                if (this.pA)
                {
                    if (this.sc < 5)
                    {
                    paramGraphics.setColor(0);
                    paramGraphics.fillRect(0, 0, 240, 320);
                    M(paramGraphics);
                    K(paramGraphics);
                    this.sc += 1;
                    }
                    E(paramGraphics);
                    this.pA = false;
                }
                if (this.kA != -1)
                {
                    this.ub[this.kA] = 0;
                    this.vb[this.kA] = 0;
                    this.wb[this.kA] = ((short)this.qA);
                    B(paramGraphics, this.kA);
                    this.sA += 1;
                    if (this.sA > 2) {
                    this.sA = 0;
                    }
                    if (this.sA != 0)
                    {
                    this.ub[this.kA] = ((byte)this.sA);
                    this.vb[this.kA] = 0;
                    this.wb[this.kA] = ((short)this.qA);
                    B(paramGraphics, this.kA);
                    }
                }
                break;
                case 202: 
                paramGraphics.setColor(0);
                paramGraphics.fillRect(0, 0, 240, 320);
                if (this.qc)
                {
                    String str = this.pc;
                    paramGraphics.setColor(16777215);
                    paramGraphics.drawString(str, 120 - yb.stringWidth(str) / 2, 160 - yb.getHeight() / 2, 20);
                }
                else
                {
                    M(paramGraphics);
                }
                K(paramGraphics);
                if (!this.qc)
                {
                    if (this.dB) {
                    L(paramGraphics);
                    }
                    i2 = -1;
                    for (i1 = 0; i1 < 3; i1++) {
                    if (this.ce[i1][1] > 0) {
                        i2++;
                    }
                    }
                    i1 = 0;
                }
                break;
                case 203: 
                case 204: 
                while (i1 < 3)
                {
                    if (this.ce[i1][1] > 0)
                    {
                    B(paramGraphics, 49, 0 + i2 * 5, 292);
                    i2--;
                    }
                    i1++;
                    continue;
                    if (this.nD)
                    {
                    paramGraphics.setColor(0);
                    paramGraphics.fillRect(0, 0, 240, 320);
                    }
                    int i3;
                    switch (this.wd)
                    {
                    case 0: 
                    break;
                    case 1: 
                    A(paramGraphics, 0, 0);
                    D(paramGraphics);
                    if (this.yd >= 0)
                    {
                        if ((this.zd != null) && (this.zd.length > 4))
                        {
                        if (this.zd[0] > -1) {
                            i2 = 30;
                        } else {
                            i2 = 55;
                        }
                        }
                        else {
                        i2 = 55;
                        }
                        A(paramGraphics, this.yd, i2, 130, true);
                    }
                    if (this.zd != null)
                    {
                        if (this.zd[0] >= 0)
                        {
                        i2 = this.zd[1];
                        if (this.yd == 11) {
                            i2 = this.ed[this.jd][this.id].c;
                        }
                        for (i1 = 0; i1 <= i2; i1++)
                        {
                            this.vb[24] = ((short)(36 + i1 * 22));
                            this.wb[24] = 170;
                            B(paramGraphics, 24);
                        }
                        if (this.yd == 11)
                        {
                            A(paramGraphics, false);
                            break;
                        }
                        if (this.zd[3] != -1)
                        {
                            if (this.ed[this.jd][this.id].a != 10)
                            {
                            A(paramGraphics, this.zd[3], 115, 90);
                            }
                            else
                            {
                            i1 = 47;
                            if (this.ed[this.jd][this.id].x) {
                                i1 = 39;
                            }
                            this.ub[i1] = 3;
                            this.vb[i1] = 125;
                            this.wb[i1] = 110;
                            B(paramGraphics, i1);
                            }
                        }
                        else {
                            A(paramGraphics, 29, 115, 90);
                        }
                        for (i1 = 4; i1 < this.zd.length; i1 += 2) {
                            if ((this.zd.length > 4) && (this.zd[i1] >= 0))
                            {
                            paramGraphics.setColor(8750469);
                            paramGraphics.drawRect(115, 90 + (i1 - 2) / 2 * 40, 92, 12);
                            paramGraphics.setColor(16776960);
                            paramGraphics.fillRect(117, 90 + (i1 - 2) / 2 * 40 + 2, 89 * this.zd[i1] / this.zd[(i1 + 1)], 9);
                            paramGraphics.drawString("" + this.zd[i1] + " / " + this.zd[(i1 + 1)], 117, 90 + (i1 - 2) / 2 * 40 + 17, 20);
                            paramGraphics.setColor(0);
                            }
                        }
                        }
                        if (this.zd[0] < 0)
                        {
                        i3 = 0;
                        i2 = 0;
                        for (i1 = 2; i1 <= 6; i1 += 2) {
                            if (this.zd[i1] != -1) {
                            i3++;
                            }
                        }
                        if (i3 > 1) {
                            if (this.lc <= 15) {
                            i2 = 0;
                            } else if (this.lc <= 30) {
                            i2 = 1;
                            } else {
                            i2 = 2;
                            }
                        }
                        A(paramGraphics, this.zd[(i2 * 2 + 2)], 150, 90);
                        paramGraphics.setColor(16777215);
                        paramGraphics.drawString("" + this.zd[(i2 * 2 + 3)], 150, 130, 20);
                        paramGraphics.setColor(0);
                        if (i3 > 1)
                        {
                            if (this.lc == i3 * 15) {
                            this.lc = -1;
                            }
                            this.lc = ((byte)(this.lc + 1));
                        }
                        }
                    }
                    A(paramGraphics, false);
                    break;
                    case 2: 
                    A(paramGraphics, 0, 0);
                    D(paramGraphics);
                    if (this.yd >= 0) {
                        A(paramGraphics, this.yd, 85, 130, true);
                    }
                    A(paramGraphics, true);
                    break;
                    case 3: 
                    A(paramGraphics, 0, 0);
                    D(paramGraphics);
                    if (this.zd != null) {
                        for (i3 = 0; i3 < this.zd.length; i3 += 2) {
                        if (((this.eD != 116) && (this.eD != 143)) || ((this.zd[i3] != ja[9]) && (this.zd[i3] >= 0)))
                        {
                            i2 = 1;
                            for (i1 = 0; i1 < ja.length; i1++) {
                            if ((this.zd[i3] == ja[i1]) && (this.zd[(i3 + 1)] > this.cc.h[i1])) {
                                i2 = 0;
                            }
                            }
                            if (i3 <= 3)
                            {
                            A(paramGraphics, this.zd[i3], 50 + i3 / 2 * 93, 80);
                            if ((i2 != 0) || (this.eD == 140)) {
                                paramGraphics.setColor(16777215);
                            } else {
                                paramGraphics.setColor(16711680);
                            }
                            paramGraphics.drawString("" + this.zd[(i3 + 1)], 95 + i3 / 2 * 93, 86, 20);
                            }
                            else
                            {
                            A(paramGraphics, this.zd[i3], 50 + (i3 - 4) / 2 * 93, 127);
                            if ((i2 != 0) || (this.eD == 140)) {
                                paramGraphics.setColor(16777215);
                            } else {
                                paramGraphics.setColor(16711680);
                            }
                            paramGraphics.drawString("" + this.zd[(i3 + 1)], 50 + (i3 - 4) / 2 * 93 + 45, 133, 20);
                            }
                            paramGraphics.setColor(0);
                        }
                        }
                    }
                    A(paramGraphics, false);
                    break;
                    case 4: 
                    A(paramGraphics, 0, 0);
                    D(paramGraphics);
                    if (this.zd != null)
                    {
                        i2 = 2;
                        while (i2 < this.zd.length)
                        {
                        if (this.zd[i2] >= -1) {
                            if (this.zd[(i2 + 1)] != -1)
                            {
                            if (this.ed[this.jd][this.id].a != 10)
                            {
                                A(paramGraphics, this.zd[(i2 + 1)], 108, 74);
                            }
                            else
                            {
                                this.ub[47] = 3;
                                this.vb[47] = 118;
                                this.wb[47] = 94;
                                B(paramGraphics, 47);
                            }
                            }
                            else {
                            A(paramGraphics, 29, 108, 74);
                            }
                        }
                        i2 += this.zd.length;
                        }
                    }
                    A(paramGraphics, false);
                    break;
                    case 5: 
                    C(paramGraphics);
                    N(paramGraphics);
                    break;
                    case 10: 
                    C(paramGraphics);
                    N(paramGraphics);
                    break;
                    case 9: 
                    C(paramGraphics);
                    N(paramGraphics);
                    this.pD = 0;
                    if (this.zd != null)
                    {
                        paramGraphics.setColor(16767412);
                        i2 = 0;
                    }
                    break;
                    case 11: 
                    case 6: 
                    case 7: 
                    case 12: 
                    case 8: 
                    case 13: 
                    while (i2 <= 2)
                    {
                        if ((30 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 >= 30 - bA[2]) && (30 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 <= 292 + bA[(this.yd * 5 + 2)])) {
                        A(paramGraphics, this.yd, 30, 30 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, false);
                        }
                        if ((70 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 >= 30 - bA[122]) && (70 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 <= 262)) {
                        for (i1 = 0; i1 < i2 + 1; i1++)
                        {
                            this.vb[24] = ((short)(36 + i1 * 22));
                            this.wb[24] = ((short)(70 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115));
                            B(paramGraphics, 24);
                        }
                        }
                        if ((this.cD == 114) || (this.cD == 110) || (this.cD == 109))
                        {
                        if (this.zd[(i2 * 2 + i2 * 28 + 1)] > 0)
                        {
                            if ((10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 >= 30 - bA[92]) && (10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 <= 262))
                            {
                            A(paramGraphics, 19, 130, 10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115);
                            A(paramGraphics, 20, 155, 10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115);
                            A(paramGraphics, 18, 180, 10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115);
                            paramGraphics.drawString("" + this.zd[(i2 * 2 + i2 * 28 + 1)], 215, 6 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                            }
                            this.pD = 2;
                        }
                        else
                        {
                            this.pD = 0;
                        }
                        }
                        else {
                        this.pD = 0;
                        }
                        for (i1 = 2 + i2 * 2 + i2 * 28; i1 < 2 + i2 * 2 + i2 * 28 + 28; i1 += 2) {
                        if (this.zd[(i1 + 1)] > 0)
                        {
                            if (this.pD < 2)
                            {
                            if ((10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 >= 30 - bA[92]) && (10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 <= 262))
                            {
                                A(paramGraphics, this.zd[i1], 130 + this.pD * 50, 10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115);
                                if ((this.cD != 114) && (this.cD != 110) && (this.cD != 109) && (this.zd[(i1 + 1)] > this.ed[this.jd][this.id].h[ka[this.zd[i1]]])) {
                                paramGraphics.setColor(16711680);
                                }
                                paramGraphics.drawString("" + this.zd[(i1 + 1)], 130 + this.pD * 50 + 35, 6 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                                paramGraphics.setColor(16767412);
                            }
                            }
                            else if ((10 + (7 - this.hD + this.oD) * yb.getHeight() + 35 + i2 * 115 >= 30 - bA[92]) && (10 + (7 - this.hD + this.oD) * yb.getHeight() + 35 + i2 * 115 <= 262))
                            {
                            A(paramGraphics, this.zd[i1], 130 + (this.pD - 2) * 50, 10 + (7 - this.hD + this.oD) * yb.getHeight() + 35 + i2 * 115);
                            if ((this.cD != 114) && (this.cD != 110) && (this.cD != 109) && (this.zd[(i1 + 1)] > this.ed[this.jd][this.id].h[ka[this.zd[i1]]])) {
                                paramGraphics.setColor(16711680);
                            }
                            paramGraphics.drawString("" + this.zd[(i1 + 1)], 130 + (this.pD - 2) * 50 + 35, 6 + (7 - this.hD + this.oD) * yb.getHeight() + 35 + i2 * 115, 20);
                            paramGraphics.setColor(16767412);
                            }
                            this.pD += 1;
                        }
                        }
                        if ((this.cD != 114) && (this.cD != 110) && (this.cD != 109)) {
                        if (this.pD == 0)
                        {
                            if ((10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 >= 30 - bA[92]) && (10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 <= 262))
                            {
                            if (this.ed[this.jd][this.id].a != 10)
                            {
                                A(paramGraphics, this.zd[(i2 * 2 + i2 * 28)], 130, 10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115);
                            }
                            else
                            {
                                this.ub[47] = 3;
                                this.vb[47] = 140;
                                this.wb[47] = ((short)(10 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 + 20));
                                B(paramGraphics, 47);
                            }
                            paramGraphics.drawString("=", 115, 6 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                            paramGraphics.drawString("" + this.zd[(i2 * 2 + i2 * 28 + 1)], 165, 6 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                            }
                        }
                        else if (this.pD <= 2)
                        {
                            if ((45 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 >= 30 - bA[92]) && (45 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 <= 262))
                            {
                            if (this.ed[this.jd][this.id].a != 10)
                            {
                                A(paramGraphics, this.zd[(i2 * 2 + i2 * 28)], 130, 45 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115);
                            }
                            else
                            {
                                this.ub[47] = 3;
                                this.vb[47] = 140;
                                this.wb[47] = ((short)(45 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 + 20));
                                B(paramGraphics, 47);
                            }
                            paramGraphics.drawString("=", 115, 41 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                            paramGraphics.drawString("" + this.zd[(i2 * 2 + i2 * 28 + 1)], 165, 41 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                            }
                        }
                        else if ((80 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 >= 30 - bA[92]) && (80 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 <= 262))
                        {
                            if (this.ed[this.jd][this.id].a != 10)
                            {
                            A(paramGraphics, this.zd[(i2 * 2 + i2 * 28)], 130, 80 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115);
                            }
                            else
                            {
                            this.ub[47] = 3;
                            this.vb[47] = 140;
                            this.wb[47] = ((short)(80 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115 + 20));
                            B(paramGraphics, 47);
                            }
                            paramGraphics.drawString("=", 115, 76 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                            paramGraphics.drawString("" + this.zd[(i2 * 2 + i2 * 28 + 1)], 165, 76 + (7 - this.hD + this.oD) * yb.getHeight() + i2 * 115, 20);
                        }
                        }
                        i2++;
                        continue;
                        C(paramGraphics);
                        N(paramGraphics);
                        switch (this.ce[this.ee][0])
                        {
                        case 1: 
                        case 4: 
                        case 9: 
                        A(paramGraphics, this.zd[0], 50, 70 + (1 - this.hD + this.oD) * yb.getHeight());
                        paramGraphics.setColor(16767412);
                        paramGraphics.drawString("" + this.zd[1], 95, 76 + (1 - this.hD + this.oD) * yb.getHeight(), 20);
                        paramGraphics.setColor(0);
                        break;
                        case 3: 
                        case 5: 
                        case 6: 
                        if (this.zd[0] != 99) {
                            if (this.gd[(this.zd[1] * 2 + 1)] == -1) {
                            A(paramGraphics, this.gd[(this.zd[1] * 2)], 50, 70 + (1 - this.hD + this.oD) * yb.getHeight() + 50, true);
                            } else {
                            A(paramGraphics, this.gd[(this.zd[1] * 2 + 1)], 50, 70 + (1 - this.hD + this.oD) * yb.getHeight() + 50, true);
                            }
                        }
                        case 2: 
                        case 7: 
                        case 8: 
                        if (this.zd[0] != 99)
                        {
                            if (this.gd[(this.zd[0] * 2 + 1)] == -1) {
                            A(paramGraphics, this.gd[(this.zd[0] * 2)], 50, 70 + (1 - this.hD + this.oD) * yb.getHeight(), true);
                            } else {
                            A(paramGraphics, this.gd[(this.zd[0] * 2 + 1)], 50, 70 + (1 - this.hD + this.oD) * yb.getHeight(), true);
                            }
                        }
                        else if (this.gd[(this.zd[1] * 2 + 1)] == -1) {
                            A(paramGraphics, this.gd[(this.zd[1] * 2)], 50, 70 + (1 - this.hD + this.oD) * yb.getHeight() + 50, true);
                        } else {
                            A(paramGraphics, this.gd[(this.zd[1] * 2 + 1)], 50, 70 + (1 - this.hD + this.oD) * yb.getHeight(), true);
                        }
                        break;
                        }
                        break;
                        this.xd = null;
                        this.zd = null;
                        this.aD = null;
                        this.cD = 0;
                        K(202);
                        break;
                        A(paramGraphics, 0, 0);
                        D(paramGraphics);
                        if (this.zd != null) {
                        for (i1 = 0; i1 < this.zd.length; i1 += 3) {
                            if ((this.zd[i1] >= 0) && (i1 < 6))
                            {
                            A(paramGraphics, this.zd[i1], 80, 80 + i1 / 2 * 53);
                            paramGraphics.setColor(16777215);
                            if ((i1 == 0) && (this.zd.length == 3)) {
                                paramGraphics.drawString("" + this.zd[(i1 + 1)] + " / " + (this.cc.h[this.zd[(i1 + 2)]] - this.zd[(i1 + 1)]), 125, 86 + i1 / 2 * 53, 20);
                            } else {
                                paramGraphics.drawString("" + (this.zd[(i1 + 1)] < 99999 ? this.zd[(i1 + 1)] : 99999), 125, 86 + i1 / 2 * 53, 20);
                            }
                            paramGraphics.setColor(0);
                            }
                        }
                        }
                        A(paramGraphics, false);
                        break;
                        A(paramGraphics, 0, 0);
                        D(paramGraphics);
                        if (this.zd != null)
                        {
                        paramGraphics.setColor(16777215);
                        A(paramGraphics, 24, 45, 54);
                        A(paramGraphics, 31, 171, 54);
                        A(paramGraphics, this.zd[0], 105, 84);
                        A(paramGraphics, this.zd[5], 105, 137);
                        paramGraphics.drawString("" + (this.zd[1] < 99999 ? this.zd[1] : 99999), 45, 90, 20);
                        paramGraphics.drawString("" + (this.zd[6] < 99999 ? this.zd[6] : 99999), 45, 143, 20);
                        if (this.zd[4] != 0) {
                            paramGraphics.drawString("+" + (this.zd[4] < 99999 ? this.zd[4] : 99999), 171, 90, 20);
                        } else {
                            paramGraphics.drawString("" + (this.zd[4] < 99999 ? this.zd[4] : 99999), 171, 90, 20);
                        }
                        paramGraphics.drawString("" + (this.zd[9] < 99999 ? this.zd[9] : 99999), 171, 143, 20);
                        paramGraphics.setColor(0);
                        }
                        A(paramGraphics, false);
                        break;
                        A(paramGraphics, 0, 0);
                        D(paramGraphics);
                        byte b1 = 0;
                        this.pD = 0;
                        if (this.zd != null)
                        {
                        for (i3 = 0; i3 < this.zd.length; i3 += 2) {
                            if (this.zd[i3] >= 0)
                            {
                            i2 = 1;
                            if (i3 <= 1)
                            {
                                if (this.zd[(i3 + 1)] > this.cc.h[2] + this.cc.h[3] + this.cc.h[4]) {
                                i2 = 0;
                                }
                            }
                            else {
                                for (i1 = 0; i1 < ja.length; i1++) {
                                if ((this.zd[i3] == ja[i1]) && (this.zd[(i3 + 1)] > this.cc.h[i1])) {
                                    i2 = 0;
                                }
                                }
                            }
                            if (i3 < 1)
                            {
                                if (this.zd[i3] >= 0)
                                {
                                if (this.rD == 0)
                                {
                                    if (80 + this.rD >= 80)
                                    {
                                    A(paramGraphics, 19, 50 + i3 / 2 * 40, 80 + this.rD);
                                    A(paramGraphics, 20, 50 + (i3 + 2) / 2 * 40, 80 + this.rD);
                                    A(paramGraphics, 18, 50 + (i3 + 4) / 2 * 40, 80 + this.rD);
                                    }
                                    if (i2 != 0) {
                                    paramGraphics.setColor(16777215);
                                    } else {
                                    paramGraphics.setColor(16711680);
                                    }
                                    paramGraphics.drawString("" + this.zd[(i3 + 1)], 50 + (i3 + 4) / 2 * 40 + 45, 86 + this.rD, 20);
                                }
                                b1 = 1;
                                }
                            }
                            else if ((this.eD != 145) || ((this.eD == 145) && (this.zd[(i3 + 1)] > 0)))
                            {
                                if ((215 - bA[92] > 80 + 47 * b1 + this.rD) && (80 + 47 * b1 + this.rD >= 80))
                                {
                                A(paramGraphics, this.zd[i3], 50 + this.pD * 40 * 2, 80 + 47 * b1 + this.rD);
                                if ((i2 != 0) || (this.eD == 141)) {
                                    paramGraphics.setColor(16777215);
                                } else {
                                    paramGraphics.setColor(16711680);
                                }
                                paramGraphics.drawString("" + this.zd[(i3 + 1)], 50 + this.pD * 40 * 2 + 45, 86 + 47 * b1 + this.rD, 20);
                                }
                                if (this.pD > 0)
                                {
                                this.pD = 0;
                                b1 = (byte)(b1 + 1);
                                }
                                else
                                {
                                this.pD += 1;
                                }
                            }
                            paramGraphics.setColor(0);
                            }
                        }
                        if (this.pD == 1) {
                            b1 = (byte)(b1 + 1);
                        }
                        this.sD = b1;
                        }
                        A(paramGraphics, false);
                        break;
                        A(paramGraphics, 0, 0);
                        D(paramGraphics);
                        A(paramGraphics);
                        if (this.vB == 0) {
                        paramGraphics.setColor(16776960);
                        } else {
                        paramGraphics.setColor(16711680);
                        }
                        i1 = 60 * this.qB / 100;
                        i3 = 161 - i1;
                        i2 = 156 - i1;
                        paramGraphics.fillRect(127, i3, 4, i1);
                        for (i1 = 0; i1 < 4; i1++) {
                        paramGraphics.drawLine(137 + i1, i3 - i1, 137 + i1, i3 + i1);
                        }
                        paramGraphics.drawString(new Byte(this.qB).toString(), 145, i2, 20);
                        paramGraphics.setColor(0);
                        A(paramGraphics, false);
                    }
                    }
                    if ((this.wd != 13) && (this.wd != 8) && (this.wd != 7) && (this.wd != 12) && (this.wd != 4) && (this.wd != 3) && (this.wd != 2) && (this.wd != 1) && (this.wd != 6)) {
                    B(paramGraphics);
                    }
                    if (this.xd != null)
                    {
                    if (this.ud / 2 * this.qb[32].getWidth() + this.qb[32].getWidth() > 240 - this.fD) {
                        this.fD = (240 - (this.ud / 2 * this.qb[32].getWidth() + this.qb[32].getWidth()));
                    } else if (this.ud / 2 * this.qb[32].getWidth() < 0 - this.fD) {
                        this.fD = (0 - this.ud / 2 * this.qb[32].getWidth());
                    }
                    for (i1 = 0; i1 < this.xd.length; i1 += 2) {
                        if (this.xd[i1] >= 0) {
                        A(paramGraphics, this.xd[i1], this.fD + 0 + i1 / 2 * bA[86] + i1 * 2, 292);
                        }
                    }
                    }
                    if (this.xd != null)
                    {
                    this.ub[19] = 0;
                    this.vb[19] = ((short)(this.fD + 0 + this.ud / 2 * this.qb[32].getWidth()));
                    this.wb[19] = 292;
                    B(paramGraphics, 19);
                    break;
                    this = D(155);
                    paramGraphics.setColor(0);
                    paramGraphics.drawString(this, 120 - yb.stringWidth(this) / 2 + 1, 160 - yb.getHeight() / 2 + 1, 20);
                    paramGraphics.setColor(16777215);
                    paramGraphics.drawString(this, 120 - yb.stringWidth(this) / 2, 160 - yb.getHeight() / 2, 20);
                    }
                }
                }
                break;
            }
            }
  
            private void B(Graphics paramGraphics, int paramInt1, int paramInt2, int paramInt3)
            {
            this.vb[paramInt1] = ((short)(paramInt2 + 2));
            this.wb[paramInt1] = ((short)(paramInt3 + 2));
            B(paramGraphics, paramInt1);
            this.vb[18] = ((short)paramInt2);
            this.wb[18] = ((short)paramInt3);
            B(paramGraphics, 18);
            }
  
            private void K(Graphics paramGraphics)
            {
            int i2 = (this.fB + 1) % 10000;
            int i1 = this.cc.h[9];
            if (i1 > 99999) {
                i1 = 99999;
            }
            paramGraphics.setColor(0);
            paramGraphics.drawString(this.oc + " " + i2, 3, 3, 20);
            paramGraphics.drawString(this.oc + " " + i2, 3, 1, 20);
            paramGraphics.drawString(this.oc + " " + i2, 3, 2, 20);
            paramGraphics.drawString(this.oc + " " + i2, 1, 3, 20);
            paramGraphics.drawString(this.oc + " " + i2, 1, 1, 20);
            paramGraphics.drawString(this.oc + " " + i2, 1, 2, 20);
            paramGraphics.drawString(this.oc + " " + i2, 2, 3, 20);
            paramGraphics.drawString(this.oc + " " + i2, 2, 1, 20);
            paramGraphics.drawString("" + i1, 217, 3, 24);
            paramGraphics.drawString("" + i1, 217, 1, 24);
            paramGraphics.drawString("" + i1, 217, 2, 24);
            paramGraphics.drawString("" + i1, 215, 3, 24);
            paramGraphics.drawString("" + i1, 215, 1, 24);
            paramGraphics.drawString("" + i1, 215, 2, 24);
            paramGraphics.drawString("" + i1, 216, 3, 24);
            paramGraphics.drawString("" + i1, 216, 1, 24);
            paramGraphics.setColor(16777215);
            paramGraphics.drawString(this.oc + " " + i2, 2, 2, 20);
            paramGraphics.setColor(16768637);
            paramGraphics.drawString("" + i1, 216, 2, 24);
            this.vb[21] = 218;
            this.wb[21] = 4;
            B(paramGraphics, 21);
            }
  
            private void L(Graphics paramGraphics)
            {
            A localA = this.ed[this.jd][this.id];
            if (localA.e == -1) {
                i1 = -1;
            } else if (localA.a == 12) {
                i1 = localA.e;
            } else {
                i1 = sa[(localA.a * 3 + localA.e)];
            }
            if ((localA.a >= 6 ? 1 : 0) == 0) {
                if ((i1 == -1) && (localA.i == 0)) {
                return;
                }
            }
            int i8 = E(this.id, this.jd);
            int i7 = BA(this.jd) + C(localA);
            int i2 = i8 + 11;
            int i1 = i7 + -26;
            this.vb[22] = ((short)i2);
            this.wb[22] = ((short)i1);
            B(paramGraphics, 22);
            i1 = 0;
            int i3;
            if (localA.a != 0)
            {
                i2 = D(localA);
                if ((localA.a >= 0) && (localA.a < 6))
                {
                i3 = 0;
                for (i2 = 0; i2 < 3; i2++) {
                    if (sa[(localA.a * 3 + i2)] != -1) {
                    i3++;
                    }
                }
                if (i3 > 1) {
                    if (this.lc <= 15) {
                    i1 = 0;
                    } else if (this.lc <= 30) {
                    i1 = 1;
                    } else {
                    i1 = 2;
                    }
                }
                i2 = this.nd[sa[(localA.a * 3 + i1)]];
                if (i3 > 1)
                {
                    if (this.lc == i3 * 15) {
                    this.lc = -1;
                    }
                    this.lc = ((byte)(this.lc + 1));
                }
                }
                if (i2 >= 0)
                {
                this.ub[20] = ((byte)i2);
                this.vb[20] = ((short)(i8 + 16));
                this.wb[20] = ((short)(i7 + -15));
                B(paramGraphics, 20);
                }
            }
            int i6 = 16776960;
            int i5 = 0;
            int i4 = 0;
            if (localA.i > 0)
            {
                i6 = 255;
                if (localA.a >= 6)
                {
                if (localA.d > 0) {
                    i4 = ca[(localA.a - 6)][(localA.d - 1)] * 100;
                } else {
                    i4 = da[(localA.a - 6)][(localA.c + 1)] * 100;
                }
                }
                else {
                i4 = z[localA.a] * 100;
                }
                i5 = i4 - localA.i;
            }
            else
            {
                D localD;
                if (localA.a >= 6)
                {
                i3 = i8 + 31;
                i2 = i7 + -11;
                for (i1 = 0; i1 <= localA.c; i1++)
                {
                    this.vb[23] = ((short)i3);
                    this.wb[23] = ((short)i2);
                    B(paramGraphics, 23);
                    i3 += 7;
                }
                if ((localA.w) && (this.od.size() > 0)) {
                    for (i2 = 0; i2 < this.od.size(); i2++)
                    {
                    localD = (D)this.od.elementAt(i2);
                    if (localA == localD.f)
                    {
                        i5 = localD.ca;
                        i4 = 700;
                        i6 = 16711680;
                    }
                    }
                }
                switch (localA.a)
                {
                case 11: 
                case 12: 
                    i5 = 1;
                    i4 = 1;
                    break;
                case 13: 
                    i5 = RB();
                    i4 = QB();
                    break;
                case 14: 
                    if (B(this.ke, localA) == -1)
                    {
                    i5 = localA.j / 20;
                    i4 = w[localA.c] / 20;
                    }
                    else
                    {
                    i5 = 0;
                    i4 = 0;
                    }
                    break;
                default: 
                    if (localA.e == -1)
                    {
                    i5 = 0;
                    i4 = 0;
                    }
                    else
                    {
                    i5 = localA.h[ha[(localA.a - 6)][(localA.c * 3 + localA.e)][14]];
                    i4 = ba[(localA.a - 6)][ha[(localA.a - 6)][(localA.c * 3 + localA.e)][14]][localA.c];
                    }
                    break;
                }
                }
                else
                {
                i5 = localA.f[localD];
                i4 = localA.g[localD];
                }
            }
            this = i8 + 31;
            i2 = i7 + -16;
            Townsmen3 localTownsmen3 = 24;
            if (i4 > 0)
            {
                if (i5 >= 0) {
                localTownsmen3 = i5 * 100 / i4 * 24 / 100;
                } else {
                localTownsmen3 = 24;
                }
            }
            else if (i4 == 0) {
                localTownsmen3 = 0;
            }
            paramGraphics.setColor(i6);
            paramGraphics.fillRect(this, i2, localTownsmen3, 2);
            paramGraphics.setColor(0);
            paramGraphics.fillRect(this + localTownsmen3, i2, 24 - localTownsmen3, 2);
            }
  
            private int A(short[] paramArrayOfShort, bool parambool)
            {
            int i1 = 2;
            int i2 = 0;
            switch (paramArrayOfShort[0])
            {
            case 0: 
                i1 = this.cc.h[paramArrayOfShort[1]];
                i1 = A(paramArrayOfShort, parambool, i1);
                break;
            case 1: 
                if (paramArrayOfShort[1] + 6 == 13)
                {
                if (this.cc.c < paramArrayOfShort[4] - 1) {
                    i1 = 0;
                }
                }
                else
                {
                Vector localVector = A(paramArrayOfShort[1] + 6, false, -1);
                int[] arrayOfInt = new int[3];
                i1 = localVector.size();
                for (;;)
                {
                    i1--;
                    if (i1 < 0) {
                    break;
                    }
                    arrayOfInt[((A)localVector.elementAt(i1)).c] += 1;
                }
                if (paramArrayOfShort[4] > 0) {
                    i1 = arrayOfInt[(paramArrayOfShort[4] - 1)];
                } else {
                    i1 = localVector.size();
                }
                i1 = A(paramArrayOfShort, parambool, i1);
                }
                break;
            case 2: 
                int i3;
                switch (paramArrayOfShort[1])
                {
                case 0: 
                i3 = this.fB + 1;
                break;
                case 1: 
                i3 = this.qB;
                break;
                case 2: 
                i3 = this.tB;
                break;
                case 3: 
                i3 = this.uB;
                break;
                case 4: 
                i3 = this.sB;
                break;
                case 5: 
                i3 = this.wB;
                break;
                case 6: 
                i3 = this.vB;
                break;
                case 7: 
                i3 = this.he;
                break;
                case 8: 
                i3 = this.ie;
                }
                if (paramArrayOfShort[1] != 9) {
                i1 = A(paramArrayOfShort, parambool, i3);
                } else {
                for (i3 = 0; i3 < this.wC; i3++) {
                    for (parambool = false; parambool < this.vC; parambool++) {
                    if ((this.ed[i3][parambool].x) && (paramArrayOfShort[2] == 0))
                    {
                        i1 = 0;
                    }
                    else if (paramArrayOfShort[2] == 1)
                    {
                        if (this.ed[i3][parambool].x) {
                        return 2;
                        }
                        i1 = 0;
                    }
                    }
                }
                }
                break;
            }
            return i1;
            }
  
            public int A(short[] paramArrayOfShort, bool parambool, int paramInt)
            {
            this = 2;
            switch (paramArrayOfShort[3])
            {
            case 0: 
                if (paramArrayOfShort[2] >= paramInt)
                {
                this = 0;
                if (parambool) {
                    this = 1;
                }
                }
                break;
            case 1: 
                if (paramArrayOfShort[2] <= paramInt)
                {
                this = 0;
                if (parambool) {
                    this = 1;
                }
                }
                break;
            case 2: 
                if (paramArrayOfShort[2] != paramInt)
                {
                this = 0;
                if (parambool) {
                    this = 1;
                }
                }
                break;
            }
            return this;
            }
  
            public bool XA()
            {
            for (int i1 = 0; i1 < objectFieldByteMatrix[0].length; i1++) {
                if (this.cc.h[objectFieldByteMatrix[0][i1]] > 0) {
                return false;
                }
            }
            A localA;
            do
            {
                int i3 = this.wC;
                i3--;
                int i2;
                do
                {
                if (i3 < 0) {
                    break;
                }
                i2 = this.vC;
                i2--;
                } while (i2 < 0);
                localA = this.ed[i3][i2];
                if ((localA.a >= 6) && (localA.a != 13)) {
                return false;
                }
            } while ((localA.a < 6) || (localA.a != 13) || ((localA.c <= 0) && (localA.e == -1)));
            return false;
            return (this.gB) && (this.cc.h[9] == 0);
            }
  
            public int YA()
            {
            int i2 = ZA();
            if (i2 != 0)
            {
                int i1 = this.lC.size();
                if (i1 > 0)
                {
                Vector localVector;
                if (i2 == 2)
                {
                    if (this.gC == 1)
                    {
                    localVector = this.lC;
                    i1 = localVector.size();
                    }
                    else
                    {
                    localVector = this.mC;
                    i1 = localVector.size();
                    }
                }
                else if (this.gC == 1)
                {
                    localVector = this.pC;
                    i1 = localVector.size();
                }
                else
                {
                    localVector = this.qC;
                    i1 = localVector.size();
                }
                if (i1 > 0)
                {
                    this.dC = new Vector();
                    for (;;)
                    {
                    i1--;
                    if (i1 < 0) {
                        break;
                    }
                    B((short[])localVector.elementAt(i1));
                    }
                    if (this.dC.size() > 0)
                    {
                    this.ec = true;
                    this.h = true;
                    K(208);
                    }
                }
                }
            }
            return i2;
            }
  
            public int ZA()
            {
            if (XA()) {
                return 1;
            }
            int i9 = 2;
            int i1 = this.jC.size();
            if (i1 > 0)
            {
                int i8 = 2;
                int i7 = 2;
                int i6 = this.jC.size();
                if (i6 > 0) {
                for (;;)
                {
                    i6--;
                    if (i6 < 0) {
                    break;
                    }
                    short[] arrayOfShort1 = (short[])this.jC.elementAt(i6);
                    int i2 = A(arrayOfShort1, false);
                    if (i2 == 0) {
                    i8 = 0;
                    }
                }
                }
                i8 = -1;
                i6 = this.kC.size();
                if (i6 > 0) {
                for (;;)
                {
                    i6--;
                    if (i6 < 0) {
                    break;
                    }
                    short[] arrayOfShort2 = (short[])this.kC.elementAt(i6);
                    if (arrayOfShort2[0] == -1)
                    {
                    i7 = -1;
                    break;
                    }
                    int i3 = A(arrayOfShort2, false);
                    if (i3 == 0) {
                    i7 = 0;
                    }
                }
                }
                i7 = -1;
                if (((i8 == 0) || (i8 == -1)) && ((i7 == 0) || (i7 == -1))) {
                i9 = 0;
                } else if (i8 == 2) {
                this.gC = 1;
                } else if (i7 == 2) {
                this.gC = 2;
                }
                i8 = 2;
                i7 = 2;
                i6 = this.nC.size();
                if (i6 > 0) {
                for (;;)
                {
                    i6--;
                    if (i6 < 0) {
                    break;
                    }
                    short[] arrayOfShort3 = (short[])this.nC.elementAt(i6);
                    int i4 = A(arrayOfShort3, false);
                    if (i4 == 0) {
                    i8 = 0;
                    }
                }
                }
                i8 = -1;
                i6 = this.oC.size();
                if (i6 > 0) {
                for (;;)
                {
                    i6--;
                    if (i6 < 0) {
                    break;
                    }
                    short[] arrayOfShort4 = (short[])this.oC.elementAt(i6);
                    if (arrayOfShort4[0] == -1)
                    {
                    i7 = -1;
                    break;
                    }
                    int i5 = A(arrayOfShort4, false);
                    if (i5 == 0) {
                    i7 = 0;
                    }
                }
                }
                i7 = -1;
                if (((i8 == 0) || (i8 == -1)) && ((i7 == 0) || (i7 == -1)))
                {
                if (i9 != 2) {
                    i9 = 0;
                }
                }
                else if (i8 == 2)
                {
                this.gC = 1;
                i9 = 1;
                }
                else if (i7 == 2)
                {
                this.gC = 2;
                i9 = 1;
                }
            }
            else
            {
                i9 = 0;
            }
            return i9;
            }
  
            public int AB()
            {
            int i7 = 2;
            int i1 = this.rC.size();
            if (i1 > 0)
            {
                Vector localVector2 = (Vector)this.rC.elementAt(this.fC);
                Vector localVector1 = (Vector)this.sC.elementAt(this.fC);
                int i6 = 2;
                int i5 = 2;
                int i4 = localVector2.size();
                if (i4 > 0) {
                for (;;)
                {
                    i4--;
                    if (i4 < 0) {
                    break;
                    }
                    short[] arrayOfShort1 = (short[])localVector2.elementAt(i4);
                    int i2 = A(arrayOfShort1, false);
                    if (i2 == 0) {
                    i6 = 0;
                    }
                }
                }
                i6 = -1;
                i4 = localVector1.size();
                if (i4 > 0) {
                for (;;)
                {
                    i4--;
                    if (i4 < 0) {
                    break;
                    }
                    short[] arrayOfShort2 = (short[])localVector1.elementAt(i4);
                    if (arrayOfShort2[0] == -1)
                    {
                    i5 = -1;
                    break;
                    }
                    int i3 = A(arrayOfShort2, false);
                    if (i3 == 0) {
                    i5 = 0;
                    }
                }
                }
                i5 = -1;
                if (((i6 == 0) || (i6 == -1)) && ((i5 == 0) || (i5 == -1))) {
                i7 = 0;
                } else if (i6 == 2) {
                this.gC = 1;
                } else if (i5 == 2) {
                this.gC = 2;
                }
            }
            else
            {
                i7 = 0;
            }
            return i7;
            }
  
            public void BB()
            {
            if (this.fC >= this.rC.size()) {
                return;
            }
            int i1 = AB();
            if (i1 == 2)
            {
                i1 = this.tC.size();
                if (i1 > 0)
                {
                Vector localVector;
                int i2;
                if (this.gC == 1)
                {
                    localVector = (Vector)this.tC.elementAt(this.fC);
                    i2 = localVector.size();
                }
                else
                {
                    localVector = (Vector)this.uC.elementAt(this.fC);
                    i2 = localVector.size();
                }
                if (i2 > 0)
                {
                    this.dC = new Vector();
                    for (i1 = 0; i1 < i2; i1++) {
                    B((short[])localVector.elementAt(i1));
                    }
                    if (this.dC.size() > 0)
                    {
                    this.ec = true;
                    this.h = true;
                    K(208);
                    }
                }
                }
                this.fC += 1;
            }
            }
  
            public void B(short[] paramArrayOfShort)
            {
            int i1;
            switch (paramArrayOfShort[0])
            {
            case 0: 
                switch (paramArrayOfShort[1])
                {
                case 0: 
                paramArrayOfShort[1] = 0;
                break;
                case 1: 
                paramArrayOfShort[1] = 1;
                break;
                case 2: 
                paramArrayOfShort[1] = 5;
                break;
                case 3: 
                paramArrayOfShort[1] = 6;
                break;
                case 4: 
                paramArrayOfShort[1] = 7;
                break;
                case 5: 
                paramArrayOfShort[1] = 8;
                break;
                case 22: 
                paramArrayOfShort[1] = 21;
                }
                N(paramArrayOfShort[1]);
                break;
            case 1: 
                this.dC.addElement(paramArrayOfShort);
                if (paramArrayOfShort[1] != 15)
                {
                this.hC[this.iC][0] = ((byte)paramArrayOfShort[1]);
                this.hC[this.iC][1] = ((byte)(paramArrayOfShort[2] - 191));
                this.iC = ((byte)(this.iC + 1));
                }
                break;
            case 2: 
                switch (paramArrayOfShort[3])
                {
                case 0: 
                this.wB = ((byte)paramArrayOfShort[2]);
                break;
                case 1: 
                this.wB = ((byte)(this.wB + paramArrayOfShort[2]));
                break;
                case 2: 
                this.wB = ((byte)(this.wB - paramArrayOfShort[2]));
                }
                break;
            case 3: 
                i1 = 0;
            case 4: 
            case 5: 
            case 6: 
            case 7: 
                while (i1 < 14)
                {
                if (paramArrayOfShort[(i1 + 4)] >= 0) {
                    switch (paramArrayOfShort[3])
                    {
                    case 0: 
                    this.cc.h[i1] = paramArrayOfShort[(i1 + 4)];
                    break;
                    case 1: 
                    this.cc.h[i1] += paramArrayOfShort[(i1 + 4)];
                    break;
                    case 2: 
                    this.cc.h[i1] -= paramArrayOfShort[(i1 + 4)];
                    }
                }
                i1++;
                continue;
                this = 6;
                while (this < 16)
                {
                    fe[this][0] = ((byte)paramArrayOfShort[((this - 6) * 2 + 3)]);
                    fe[this][1] = ((byte)paramArrayOfShort[((this - 6) * 2 + 4)]);
                    this++;
                    continue;
                    switch (paramArrayOfShort[1])
                    {
                    case 0: 
                    switch (paramArrayOfShort[2])
                    {
                    case 0: 
                        this.gB = true;
                        break;
                    case 1: 
                        this.gB = false;
                    }
                    break;
                    case 1: 
                    switch (paramArrayOfShort[2])
                    {
                    case 0: 
                        this.lB = true;
                        break;
                    case 1: 
                        this.lB = false;
                    }
                    break;
                    case 2: 
                    switch (paramArrayOfShort[2])
                    {
                    case 0: 
                        this.zB = false;
                        break;
                    case 1: 
                        this.zB = true;
                    }
                    break;
                    case 3: 
                    switch (paramArrayOfShort[2])
                    {
                    case 0: 
                        this.ac = false;
                        break;
                    case 1: 
                        this.ac = true;
                    }
                    break;
                    case 4: 
                    switch (paramArrayOfShort[2])
                    {
                    case 0: 
                        this.nB = true;
                        break;
                    case 1: 
                        this.nB = false;
                    }
                    break;
                    }
                    break;
                    this.qB = ((byte)paramArrayOfShort[1]);
                    WB();
                    break;
                    this.jB = ((this.eB / 100 + paramArrayOfShort[1]) * 100);
                    this.iB = (paramArrayOfShort[2] * 100);
                    WB();
                }
                }
            }
            }
  
            private void AA(int paramInt) //throws Exception
            {
            UA();
            this.id = 0;
            this.jd = 0;
            this.kd = 2;
            this.ld = 2;
            Object localObject = getClass().getResourceAsStream("/m");
            localObject = new DataInputStream((InputStream)localObject);
            short[] arrayOfShort = A((InputStream)localObject);
            for (int i1 = 0; i1 < paramInt; i1++) {
                ((DataInputStream)localObject).skip(arrayOfShort[i1]);
            }
            F((DataInputStream)localObject);
            this.vC = ((DataInputStream)localObject).readByte();
            this.wC = ((DataInputStream)localObject).readByte();
            this.xC = 0;
            this.yC = 0;
            this.zC = 0;
            this.ad = 0;
            this.cd = 5;
            this.dd = 20;
            this.ed = new A[this.wC][this.vC];
            A((DataInputStream)localObject, (bool[][])null, (bool[][])null, true);
            FB();
            GB();
            int i2 = this.wC;
            for (;;)
            {
                i2--;
                if (i2 < 0) {
                break;
                }
                i1 = this.vC;
                for (;;)
                {
                i1--;
                if (i1 < 0) {
                    break;
                }
                paramInt = this.ed[i2][i1];
                if ((paramInt.a >= 6) && (paramInt.a != 12) && (paramInt.a != 11))
                {
                    paramInt.k = 1000;
                    if (paramInt.e != -1) {
                    paramInt.l = ((short)(ga[(paramInt.a - 6)][paramInt.e] * 100));
                    }
                }
                }
            }
            ((DataInputStream)localObject).close();
            RA();
            ZB();
            }
  
            private void M(Graphics paramGraphics)
            {
            int i8 = this.yC;
            int i7 = i8 + this.dd < this.wC ? i8 + this.dd : this.wC;
            int i6 = this.id;
            int i5 = this.jd;
            if ((i7 <= 0) || (i8 >= i7))
            {
                this.dd = 20;
                this.wC = this.ed[0].length;
                this.yC = 0;
                D(this.cc.t, this.cc.u);
                GB();
                return;
            }
            int i4 = this.ad;
            while (i8 < i7)
            {
                int i3 = this.xC;
                i2 = i3 + this.cd < this.vC ? i3 + this.cd : this.vC;
                if (i2 <= 0)
                {
                this.cd = 5;
                this.vC = this.ed.length;
                this.xC = 0;
                D(this.cc.t, this.cc.u);
                GB();
                return;
                }
                i1 = this.zC;
                if ((i8 & 0x1) > 0) {
                i1 += 36;
                }
                while (i3 < i2)
                {
                if ((i3 != i6) || (i8 != i5)) {
                    A(paramGraphics, i3, i8, i1, i4, 0);
                }
                i1 += 72;
                i3++;
                }
                i4 += 18;
                i8++;
            }
            int i2 = this.zC + (i6 - this.xC) * 72 + ((i5 & 0x1) > 0 ? 36 : 0);
            int i1 = this.ad + (i5 - this.yC) * 18;
            if (this.n == 205) {
                A(paramGraphics, i6, i5, i2, i1, 2);
            } else {
                A(paramGraphics, i6, i5, i2, i1, 1);
            }
            }
  
            private void A(Graphics paramGraphics, int paramInt1, int paramInt2, int paramInt3, int paramInt4, int paramInt5)
            {
            A localA = this.ed[paramInt2][paramInt1];
            int i3;
            if ((localA.i > 0) && (localA.a >= 6) && (localA.d == 1)) {
                i3 = 32;
            } else {
                i3 = localA.a * 2;
            }
            int i2 = this.gd[i3];
            if (i2 != -1)
            {
                i1 = localA.b;
                if (localA.a >= 6) {
                i1 = 0;
                }
                this.ub[i2] = i1;
                this.vb[i2] = ((short)paramInt3);
                this.wb[i2] = ((short)paramInt4);
                B(paramGraphics, i2);
            }
            if (paramInt5 == 1)
            {
                this.ub[16] = 0;
                this.vb[16] = ((short)paramInt3);
                this.wb[16] = ((short)paramInt4);
                B(paramGraphics, 16);
            }
            paramInt5 = this.gd[(i3 + 1)];
            if (paramInt5 != -1)
            {
                if ((localA.i == 0) && (localA.a >= 6)) {
                if ((localA.e > -1) && (this.n != 204) && (this.n != 209))
                {
                    if (this.fd == 0)
                    {
                    if ((localA.y) && (localA.a != 15))
                    {
                        A tmp256_254 = localA;
                        tmp256_254.b = ((byte)(tmp256_254.b - 1));
                        if (localA.b <= 1) {
                        localA.y = false;
                        }
                    }
                    else
                    {
                        A tmp286_284 = localA;
                        tmp286_284.b = ((byte)(tmp286_284.b + 1));
                        if (localA.b >= 3) {
                        localA.y = true;
                        }
                    }
                    A tmp313_311 = localA;
                    tmp313_311.b = ((byte)(tmp313_311.b % T(paramInt5)));
                    if ((localA.b == 0) && (localA.a != 15)) {
                        localA.b = 1;
                    }
                    }
                }
                else {
                    localA.b = 1;
                }
                }
                if (localA.a >= 6)
                {
                this.ub[paramInt5] = 0;
                this.vb[paramInt5] = ((short)paramInt3);
                this.wb[paramInt5] = ((short)paramInt4);
                B(paramGraphics, paramInt5);
                }
                this.ub[paramInt5] = localA.b;
                this.vb[paramInt5] = ((short)paramInt3);
                this.wb[paramInt5] = ((short)paramInt4);
                B(paramGraphics, paramInt5);
            }
            if (localA.v != -1)
            {
                this.ub[20] = localA.v;
                this.vb[20] = ((short)(paramInt3 + 32));
                this.wb[20] = ((short)(paramInt4 + 26));
                B(paramGraphics, 20);
            }
            int i1 = localA.o.size();
            if ((this.n != 209) || (this.ed[this.jd][this.id] != localA)) {
                for (;;)
                {
                i1--;
                if (i1 < 0) {
                    break;
                }
                paramInt5 = (D)localA.o.elementAt(i1);
                paramInt5.A(paramGraphics);
                }
            }
            paramInt5 = A(this.cc.t, this.cc.u, 3, -1, false);
            if ((localA.a == 3) && (paramInt1 == paramInt5.t) && (paramInt2 == paramInt5.u))
            {
                paramInt5 = 32;
                if (this.vB == 1) {
                paramInt5 = 42;
                }
                if (this.fd == 0)
                {
                this.hd += 1;
                this.hd %= 2;
                }
                if (this.hB)
                {
                this.ub[paramInt5] = ((byte)this.hd);
                this.vb[paramInt5] = ((short)paramInt3);
                this.wb[paramInt5] = ((short)paramInt4);
                B(paramGraphics, paramInt5);
                }
            }
            if ((localA.a == 3) && (paramInt1 == this.vC - 1) && (paramInt2 == this.wC - 1))
            {
                paramInt1 = 32;
                if (this.vB == 1) {
                paramInt1 = 42;
                }
                if (this.fd == 0)
                {
                this.hd += 1;
                this.hd %= 2;
                }
                if (A(this.ke) != -1)
                {
                this.ub[paramInt1] = ((byte)this.hd);
                this.vb[paramInt1] = ((short)(paramInt3 + 10));
                this.wb[paramInt1] = ((short)(paramInt4 + 40));
                B(paramGraphics, paramInt1);
                }
            }
            paramInt2 = localA.s;
            paramInt1 = 8;
            while (paramInt2 > 0)
            {
                paramInt1--;
                if (paramInt1 < 0) {
                break;
                }
                if (localA.r[paramInt1] != -1)
                {
                C(paramGraphics, localA.r[paramInt1]);
                paramInt2--;
                }
            }
            if ((localA.w) && (((this.n != 209) && (this.n != 204)) || (this.ed[this.jd][this.id] != localA)))
            {
                paramInt1 = 38;
                if (localA.x) {
                paramInt1 = 39;
                }
                this.ub[paramInt1] = 0;
                this.vb[paramInt1] = ((short)(paramInt3 + 34 + 2));
                this.wb[paramInt1] = ((short)(paramInt4 + 36));
                B(paramGraphics, paramInt1);
            }
            }
  
            public void DB()
            {
            int i2 = E(this.id, this.jd);
            for (int i1 = BA(this.jd); (i2 < 0) || (i2 > 168) || (i1 < 0) || (i1 > 284); i1 = BA(this.jd))
            {
                EB();
                i2 = E(this.id, this.jd);
            }
            }
  
            private void EB()
            {
            int i1 = E(this.id, this.jd) + 72 - 240;
            if (i1 >= 0)
            {
                this.zC -= i1;
                while ((this.zC <= 65392) && (this.xC < this.vC - 1))
                {
                this.zC += 72;
                this.xC += 1;
                }
            }
            i1 = E(this.id, this.jd);
            if (i1 < 0)
            {
                this.zC -= i1;
                while ((this.zC > -36) && (this.xC > 0))
                {
                this.zC -= 72;
                this.xC -= 1;
                }
            }
            i1 = BA(this.jd) + 36 - 320;
            if (i1 >= 0)
            {
                this.ad -= i1;
                while ((this.ad < -36) && (this.yC < this.wC - 1))
                {
                this.ad += 36;
                this.yC += 1;
                }
            }
            i1 = BA(this.jd);
            if (i1 < 0)
            {
                this.ad -= i1;
                while ((this.ad > -36) && (this.yC > 0))
                {
                this.ad -= 36;
                this.yC -= 1;
                }
            }
            }
  
            public void D(int paramInt1, int paramInt2)
            {
            if ((paramInt1 < this.xC) || (paramInt1 >= this.xC + this.cd) || (paramInt2 < this.yC) || (paramInt2 >= this.yC + this.dd))
            {
                this.xC = (paramInt1 - this.cd / 2);
                if (this.xC < 0) {
                this.xC = 0;
                } else if (this.xC + this.cd >= this.vC) {
                this.xC = (this.vC - this.cd);
                }
                this.yC = (paramInt2 - this.dd / 2);
                if (this.yC < 0) {
                this.yC = 0;
                } else if (this.yC + this.dd >= this.wC) {
                this.yC = (this.wC - this.dd);
                }
            }
            this.id = paramInt1;
            this.jd = paramInt2;
            DB();
            }
  
            public int E(int paramInt1, int paramInt2)
            {
            return this.zC + (paramInt1 - this.xC) * 72 + ((paramInt2 & 0x1) > 0 ? 36 : 0);
            }
  
            public int BA(int paramInt)
            {
            return this.ad + (paramInt - this.yC) * 18;
            }
  
            public int C(A paramA)
            {
            int i2 = paramA.a * 2;
            int i1 = this.gd[i2];
            paramA = 0;
            if (i1 != -1) {
                paramA = bA[(5 * i1 + 4)];
            }
            this = this.gd[(i2 + 1)];
            if (this != -1)
            {
                this = bA[(5 * this + 4)];
                if (this < paramA) {
                paramA = this;
                }
            }
            return paramA;
            }
  
            public Vector A(int paramInt1, bool parambool, int paramInt2)
            {
            Vector localVector = new Vector();
            int i2 = this.wC;
            for (;;)
            {
                i2--;
                if (i2 < 0) {
                break;
                }
                int i1 = this.vC;
                for (;;)
                {
                i1--;
                if (i1 < 0) {
                    break;
                }
                A localA = this.ed[i2][i1];
                if (((localA.a != paramInt1) && (paramInt1 != 17) && (paramInt1 != 18) && (paramInt1 != 19) && (paramInt1 != 20)) || (((localA.i == 0) && (((!localA.w) && (paramInt1 != 19) && (paramInt1 != 20)) || ((localA.w) && ((paramInt1 == 19) || (paramInt1 == 20))))) || ((localA.a == paramInt1) && ((paramInt1 == 11) || (paramInt1 == 12)) && (((localA.a != 11) && (localA.a != 12) && (localA.a != 10) && (localA.a != 3) && (localA.a != 2)) || ((paramInt1 != 17) && (((localA.a != 11) && (localA.a != 12)) || ((paramInt1 != 18) && ((localA.a != 10) || (localA.e != -1) || (paramInt1 == 20)) && ((paramInt1 != 20) || (localA.a == 10))))))))) {
                    if (localA.a >= 6)
                    {
                    if ((!parambool) || (paramInt2 == -1) || ((parambool) && (localA.h[paramInt2] != 0))) {
                        localVector.addElement(localA);
                    }
                    }
                    else if ((!parambool) || (paramInt2 == -1) || ((parambool) && (localA.f[paramInt2] != 0))) {
                    localVector.addElement(localA);
                    }
                }
                }
            }
            return localVector;
            }
  
            public A DA(int paramInt)
            {
            int i2 = this.wC;
            A localA;
            do
            {
                i2--;
                int i1;
                do
                {
                if (i2 < 0) {
                    break;
                }
                i1 = this.vC;
                i1--;
                } while (i1 < 0);
                localA = this.ed[i2][i1];
            } while ((localA.a != paramInt) || (localA.i != 0));
            return localA;
            return null;
            }
  
            public A A(int paramInt1, int paramInt2, int paramInt3, int paramInt4, bool parambool)
            {
            Vector localVector = A(paramInt3, parambool, paramInt4);
            int i1 = localVector.size();
            if (i1 == 0) {
                return null;
            }
            if (i1 == 1) {
                return (A)localVector.elementAt(0);
            }
            parambool = new int[i1];
            int i3 = i1;
            for (;;)
            {
                i3--;
                if (i3 < 0) {
                break;
                }
                A localA = (A)localVector.elementAt(i3);
                parambool[i3] = A(paramInt1, paramInt2, localA.t, localA.u);
            }
            if (paramInt4 != -1) {}
            i3 = 0;
            while (i3 < i1) {
                for (int i2 = 0; i2 < i1 - 1; i2++) {
                if (parambool[i2] < parambool[(i2 + 1)])
                {
                    i3++;
                }
                else
                {
                    paramInt2 = (A)localVector.elementAt(i2);
                    paramInt1 = (A)localVector.elementAt(i2 + 1);
                    if ((parambool[i2] == parambool[(i2 + 1)]) && ((paramInt4 == -1) || ((paramInt3 == 10) && ((paramInt2.h[paramInt4] == -1) || ((paramInt1.h[paramInt4] != -1) && (paramInt2.h[paramInt4] >= paramInt1.h[paramInt4])))) || ((paramInt3 != 10) && ((paramInt2.f[paramInt4] == -1) || ((paramInt1.f[paramInt4] != -1) && (paramInt2.f[paramInt4] >= paramInt1.f[paramInt4]))))))
                    {
                    i3++;
                    }
                    else
                    {
                    i3 = 0;
                    this = parambool[i2];
                    parambool[i2] = parambool[(i2 + 1)];
                    parambool[(i2 + 1)] = this;
                    localVector.setElementAt(paramInt1, i2);
                    localVector.setElementAt(paramInt2, i2 + 1);
                    }
                }
                }
            }
            return (A)localVector.elementAt(0);
            }
  
            public A F(int paramInt1, int paramInt2)
            {
            Vector localVector = new Vector();
            int i2 = this.wC;
            for (;;)
            {
                i2--;
                if (i2 < 0) {
                break;
                }
                int i1 = this.vC;
                for (;;)
                {
                i1--;
                if (i1 < 0) {
                    break;
                }
                A localA = this.ed[i2][i1];
                if ((localA.a >= 6) && (localA.c <= paramInt1) && (localA.e >= paramInt2) && (localA.i == 0) && (localA.a != 12) && (localA.a != 11) && ((localA.a != 13) || (localA.c != 0)) && (localA.a != 14)) {
                    localVector.addElement(localA);
                }
                }
            }
            if (localVector.size() > 0) {
                return (A)localVector.elementAt(G(0, localVector.size() - 1));
            }
            return null;
            }
  
            public A B(byte[] paramArrayOfByte)
            {
            Vector localVector = new Vector();
            int i3 = this.wC;
            label15:
            i3--;
            if (i3 >= 0)
            {
                int i2 = this.vC;
                for (;;)
                {
                i2--;
                if (i2 < 0) {
                    break label15;
                }
                A localA = this.ed[i3][i2];
                if (localA.i != 0) {
                    break;
                }
                int i1 = paramArrayOfByte.length;
                for (;;)
                {
                    i1--;
                    if (i1 < 0) {
                    break;
                    }
                    if (localA.a == paramArrayOfByte[i1]) {
                    localVector.addElement(localA);
                    }
                }
                }
            }
            if (localVector.size() > 0) {
                return (A)localVector.elementAt(G(0, localVector.size() - 1));
            }
            return null;
            }
  
        public void FB()
        {
            for (int i2 = this.wC; i2 >=0; i2--)
            {
                for (int i1 = this.vC; i1 >= 0; i1--)
                {
                    if ((this.ed[i2][i1].a >= 0) && (this.ed[i2][i1].a < 6)) {
                        this.ed[i2][i1].b = ((byte)G(0, 3));
                    }
                }
            }
        }
  
            public void GB()
            {
            int i1 = this.vC * 72 + 36;
            if (i1 < 240) {
                this.zC = ((240 - i1) / 2);
            }
            i1 = this.wC * 36 / 2;
            if (i1 < 320) {
                this.ad = ((320 - i1) / 2);
            }
            this.bd = 0;
            i1 = BA(this.jd) - 86;
            if (i1 < 0)
            {
                this.bd = (-i1);
                i1 = this.yC < this.bd / 18 ? this.yC : this.bd / 18;
                this.yC -= i1;
                this.bd -= i1 * 18;
                this.ad += this.bd;
            }
            DB();
            }
  
            public void HB()
            {
            if ((this.kd != this.id) || (this.ld != this.jd))
            {
                this.cB = System.currentTimeMillis();
                this.dB = false;
                GB();
                this.kd = this.id;
                this.ld = this.jd;
            }
            }
  
            public void IB()
            {
            int i1 = A(this.dc, 3);
            if (i1 == 2) {
                A(b, D(33), D(34));
            } else if (i1 == 1) {
                A(b, D(33), D(36));
            }
            }
  
            public void JB()
            {
            byte[] arrayOfByte = C(3);
            if (arrayOfByte.length > 1) {
                System.arraycopy(arrayOfByte, 0, this.dc, 0, this.dc.length < arrayOfByte.length ? this.dc.length : arrayOfByte.length);
            }
            }
  
            public void KB()
            {
            ByteArrayOutputStream localByteArrayOutputStream = null;
            DataOutputStream localDataOutputStream = null;
            try
            {
                try
                {
                localByteArrayOutputStream = new ByteArrayOutputStream();
                localDataOutputStream = new DataOutputStream(localByteArrayOutputStream);
                int i3 = 0;
                for (int i2 = 0; (i2 < 5) && (this.xB[i2] != null); i2++) {}
                localDataOutputStream.writeByte((byte)i2);
                for (int i1 = 0; i1 < i2; i1++) {
                    if (this.xB[i1].length() == 10) {
                    i3 = (byte)(i3 | 1 << i1);
                    }
                }
                localDataOutputStream.writeByte(i3);
                for (i1 = 0; i1 < i2; i1++) {
                    if (this.xB[i1].length() == 10) {
                    localDataOutputStream.write(this.xB[i1].getBytes(), 0, 10);
                    } else {
                    localDataOutputStream.writeByte(this.xB[i1].getBytes()[0]);
                    }
                }
                if (this.yB != null)
                {
                    localDataOutputStream.writeByte((byte)this.yB.length());
                    localDataOutputStream.writeUTF(this.yB);
                }
                else
                {
                    localDataOutputStream.writeByte(0);
                }
                i1 = A(localByteArrayOutputStream.toByteArray(), 2);
                if (i1 == 2) {
                    A(b, D(33), D(34));
                } else if (i1 == 1) {
                    A(b, D(33), D(36));
                }
                }
                catch (Exception localException1) {}
                try
                {
                localByteArrayOutputStream.close();
                localDataOutputStream.close();
                }
                catch (Exception localException2) {}
                this = 0;
            }
            finally
            {
                try
                {
                localByteArrayOutputStream.close();
                localDataOutputStream.close();
                }
                catch (Exception localException3) {}
            }
            while (this < 5) {
                this++;
            }
            }
  
            public void LB()
            {
            this.xB = new String[5];
            byte[] arrayOfByte1 = C(2);
            if (arrayOfByte1.length != 1)
            {
                ByteArrayInputStream localByteArrayInputStream = null;
                DataInputStream localDataInputStream = null;
                try
                {
                try
                {
                    localByteArrayInputStream = new ByteArrayInputStream(arrayOfByte1);
                    localDataInputStream = new DataInputStream(localByteArrayInputStream);
                    int i4 = localDataInputStream.readByte();
                    int i3 = localDataInputStream.readByte();
                    for (int i2 = 0; i2 < i4; i2++)
                    {
                    if ((i3 >> i2 & 0x1) == 1)
                    {
                        arrayOfByte2 = new byte[10];
                        for (i1 = 0; i1 < 10; i1++) {
                        arrayOfByte2[i1] = localDataInputStream.readByte();
                        }
                    }
                    byte[] arrayOfByte2 = new byte[1];
                    arrayOfByte2[0] = localDataInputStream.readByte();
                    this.xB[i2] = new String(arrayOfByte2);
                    }
                    int i1 = localDataInputStream.readByte();
                    if (i1 != 0) {
                    this.yB = localDataInputStream.readUTF();
                    }
                }
                catch (Exception localException1) {}
                return;
                }
                finally
                {
                try
                {
                    localByteArrayInputStream.close();
                    localDataInputStream.close();
                }
                catch (Exception localException3) {}
                }
            }
            }
  
            public void A(int[] paramArrayOfInt)
            {
            ByteArrayOutputStream localByteArrayOutputStream = null;
            DataOutputStream localDataOutputStream = null;
            try
            {
                try
                {
                localByteArrayOutputStream = new ByteArrayOutputStream();
                localDataOutputStream = new DataOutputStream(localByteArrayOutputStream);
                localDataOutputStream.writeInt(paramArrayOfInt[0]);
                localDataOutputStream.writeInt(paramArrayOfInt[1]);
                paramArrayOfInt = A(localByteArrayOutputStream.toByteArray(), 6);
                if (paramArrayOfInt == 2) {
                    A(b, D(33), D(34));
                } else if (paramArrayOfInt == 1) {
                    A(b, D(33), D(36));
                }
                }
                catch (Exception localException1) {}
                return;
            }
            finally
            {
                try
                {
                localByteArrayOutputStream.close();
                localDataOutputStream.close();
                }
                catch (Exception localException3) {}
            }
            }
  
            public int[] MB()
            {
            arrayOfInt = new int[2];
            this = C(6);
            if (this.length == 1)
            {
                arrayOfInt[0] = 0;
                arrayOfInt[1] = 0;
            }
            else
            {
                ByteArrayInputStream localByteArrayInputStream = null;
                DataInputStream localDataInputStream = null;
                try
                {
                try
                {
                    localByteArrayInputStream = new ByteArrayInputStream(this);
                    localDataInputStream = new DataInputStream(localByteArrayInputStream);
                    arrayOfInt[0] = localDataInputStream.readInt();
                    arrayOfInt[1] = localDataInputStream.readInt();
                }
                catch (Exception localException1) {}
                return arrayOfInt;
                }
                finally
                {
                try
                {
                    localByteArrayInputStream.close();
                    localDataInputStream.close();
                }
                catch (Exception localException3) {}
                }
            }
            }
  
            public int NB()
            {
            int i1 = 0;
            for (int i4 = 0; i4 < this.wC; i4++) {
                for (int i3 = 0; i3 < this.vC; i3++)
                {
                A localA = this.ed[i4][i3];
                if ((localA.a >= 6) && ((localA.a != 10) || (!localA.x))) {
                    for (int i2 = 0; i2 < 14; i2++) {
                    if (i2 != 9)
                    {
                        i1 += localA.h[i2] * ia[1][this.cc.c][i2];
                        i1 += ea[(localA.a - 6)][0][i2] * ia[1][this.cc.c][i2];
                        if (localA.c > 0) {
                        i1 += ea[(localA.a - 6)][1][i2] * ia[1][this.cc.c][i2];
                        }
                        if (localA.c > 1) {
                        i1 += ea[(localA.a - 6)][2][i2] * ia[1][this.cc.c][i2];
                        }
                    }
                    else
                    {
                        i1 += localA.h[9];
                        i1 += ea[(localA.a - 6)][0][i2];
                        if (localA.c > 0) {
                        i1 += ea[(localA.a - 6)][1][i2];
                        }
                        if (localA.c > 1) {
                        i1 += ea[(localA.a - 6)][2][i2];
                        }
                    }
                    }
                }
                }
            }
            return i1;
            }
  
            public void OB()
            {
            this.md += 1;
            if (this.md >= 1000)
            {
                this.md = 0;
                EA(4);
            }
            }
  
            public void EA(int paramInt)
            {
            ByteArrayOutputStream localByteArrayOutputStream = null;
            DataOutputStream localDataOutputStream = null;
            try
            {
                try
                {
                localByteArrayOutputStream = new ByteArrayOutputStream();
                localDataOutputStream = new DataOutputStream(localByteArrayOutputStream);
                A(localDataOutputStream);
                if (this.gc) {
                    localDataOutputStream.writeByte(this.jc);
                }
                C(localDataOutputStream);
                D(localDataOutputStream);
                E(localDataOutputStream);
                F(localDataOutputStream);
                G(localDataOutputStream);
                B(localDataOutputStream);
                paramInt = A(localByteArrayOutputStream.toByteArray(), paramInt);
                if (paramInt == 2) {
                    A(b, D(33), D(34));
                } else if (paramInt == 1) {
                    A(b, D(33), D(36));
                }
                }
                catch (Exception localException1) {}
                return;
            }
            finally
            {
                try
                {
                localByteArrayOutputStream.close();
                localDataOutputStream.close();
                }
                catch (Exception localException3) {}
            }
            }
  
            public void FA(int paramInt)
            {
            UA();
            this.jC = new Vector();
            paramInt = A(paramInt, true);
            if (paramInt.length == 1)
            {
                A(b, D(33), D(35));
            }
            else
            {
                ByteArrayInputStream localByteArrayInputStream = null;
                DataInputStream localDataInputStream2 = null;
                try
                {
                try
                {
                    localByteArrayInputStream = new ByteArrayInputStream(paramInt);
                    localDataInputStream2 = new DataInputStream(localByteArrayInputStream);
                    A(localDataInputStream2);
                    bool[][] arrayOfbool2 = new bool[this.wC][this.vC];
                    bool[][] arrayOfbool1 = new bool[this.wC][this.vC];
                    if (this.gc)
                    {
                    this.jc = localDataInputStream2.readByte();
                    paramInt = getClass().getResourceAsStream("/m");
                    DataInputStream localDataInputStream1 = new DataInputStream(paramInt);
                    short[] arrayOfShort = A(localDataInputStream1);
                    for (paramInt = 0; paramInt < this.jc; paramInt++) {
                        localDataInputStream1.skip(arrayOfShort[paramInt]);
                    }
                    F(localDataInputStream1);
                    }
                    try
                    {
                    A(localDataInputStream2, arrayOfbool2, arrayOfbool1, false);
                    }
                    catch (Exception localException1) {}
                    try
                    {
                    A(localDataInputStream2, arrayOfbool2, arrayOfbool1);
                    }
                    catch (Exception localException2) {}
                    try
                    {
                    C(localDataInputStream2);
                    }
                    catch (Exception localException3) {}
                    try
                    {
                    D(localDataInputStream2);
                    }
                    catch (Exception localException4) {}
                    E(localDataInputStream2);
                    B(localDataInputStream2);
                    this.id = 0;
                    this.jd = 0;
                    this.kd = 2;
                    this.ld = 2;
                    this.cd = 5;
                    this.dd = 20;
                    this.xC = 0;
                    this.yC = 0;
                    this.zC = 0;
                    this.ad = 0;
                    D(this.cc.t, this.cc.u);
                    GB();
                }
                catch (Exception localException5) {}
                return;
                }
                finally
                {
                try
                {
                    localByteArrayInputStream.close();
                    localDataInputStream2.close();
                }
                catch (Exception localException7) {}
                }
            }
            }
  
            public void A(DataOutputStream paramDataOutputStream) //throws Exception
            {
            paramDataOutputStream.writeInt(this.qd);
            paramDataOutputStream.writeInt(this.vD);
            paramDataOutputStream.writeInt(this.tc);
            paramDataOutputStream.writeInt(this.eB);
            paramDataOutputStream.writeByte((byte)this.vC);
            paramDataOutputStream.writeByte((byte)this.wC);
            paramDataOutputStream.writeByte((byte)this.fC);
            paramDataOutputStream.writeByte((byte)this.gC);
            paramDataOutputStream.writeByte(this.qB);
            paramDataOutputStream.writeInt(this.sB);
            paramDataOutputStream.writeInt(this.tB);
            paramDataOutputStream.writeInt(this.uB);
            paramDataOutputStream.writeShort(this.xD);
            int i1 = 0;
            if (this.vB != 0) {
                i1 = 1;
            }
            if (this.hB) {
                i1 = (byte)(i1 | 0x2);
            }
            if (this.iB != -1) {
                i1 = (byte)(i1 | this.iB / 100 << 2);
            }
            paramDataOutputStream.writeByte(i1);
            paramDataOutputStream.writeByte(this.wB);
            i1 = 0;
            if (this.gB) {
                i1 = 1;
            }
            if (this.lB) {
                i1 = (byte)(i1 | 0x2);
            }
            if (this.zB) {
                i1 = (byte)(i1 | 0x4);
            }
            if (this.ac) {
                i1 = (byte)(i1 | 0x8);
            }
            if (this.nB) {
                i1 = (byte)(i1 | 0x10);
            }
            if (this.mB) {
                i1 = (byte)(i1 | 0x20);
            }
            paramDataOutputStream.writeByte(i1);
            i1 = (byte)(fe[6][0] + 1);
            i1 = (byte)(i1 | fe[6][1] + 1 << 2);
            i1 = (byte)(i1 | fe[7][0] + 1 << 4);
            i1 = (byte)(i1 | fe[7][1] + 1 << 6);
            paramDataOutputStream.writeByte(i1);
            i1 = (byte)(fe[8][0] + 1);
            i1 = (byte)(i1 | fe[8][1] + 1 << 2);
            i1 = (byte)(i1 | fe[9][0] + 1 << 4);
            i1 = (byte)(i1 | fe[10][0] + 1 << 6);
            paramDataOutputStream.writeByte(i1);
            i1 = (byte)(fe[13][0] + 1);
            i1 = (byte)(i1 | fe[14][0] + 1 << 2);
            i1 = (byte)(i1 | fe[15][0] + 1 << 4);
            i1 = (byte)(i1 | fe[15][1] + 1 << 6);
            paramDataOutputStream.writeByte(i1);
            paramDataOutputStream.writeByte(this.iC);
            for (i1 = 0; i1 < this.hC.length; i1++)
            {
                paramDataOutputStream.writeByte(this.hC[i1][0]);
                paramDataOutputStream.writeByte(this.hC[i1][1]);
            }
            }
  
            public void A(DataInputStream paramDataInputStream) //throws Exception
            {
            this.qd = paramDataInputStream.readInt();
            this.vD = paramDataInputStream.readInt();
            this.tc = paramDataInputStream.readInt();
            this.eB = paramDataInputStream.readInt();
            this.fB = (this.eB / 100);
            this.vC = paramDataInputStream.readByte();
            this.wC = paramDataInputStream.readByte();
            this.ed = ((A[][])null);
            this.ed = new A[this.wC][this.vC];
            this.fC = paramDataInputStream.readByte();
            this.gC = paramDataInputStream.readByte();
            this.qB = paramDataInputStream.readByte();
            this.sB = paramDataInputStream.readInt();
            this.tB = paramDataInputStream.readInt();
            this.uB = paramDataInputStream.readInt();
            this.xD = paramDataInputStream.readShort();
            int i1 = paramDataInputStream.readByte();
            this.vB = ((byte)(i1 >> 0 & 0x1));
            this.hB = ((i1 >> 1 & 0x1) == 1);
            this.iB = ((i1 >> 2 & 0xF) * 100);
            if (this.iB == 0) {
                this.iB = -1;
            }
            this.wB = paramDataInputStream.readByte();
            i1 = paramDataInputStream.readByte();
            this.gB = ((i1 >> 0 & 0x1) == 1);
            this.lB = ((i1 >> 1 & 0x1) == 1);
            this.zB = ((i1 >> 2 & 0x1) == 1);
            this.ac = ((i1 >> 3 & 0x1) == 1);
            this.nB = ((i1 >> 4 & 0x1) == 1);
            this.mB = ((i1 >> 5 & 0x1) == 1);
            i1 = paramDataInputStream.readByte();
            fe[6][0] = ((byte)((i1 & 0x3) - 1));
            fe[6][1] = ((byte)((i1 >> 2 & 0x3) - 1));
            fe[7][0] = ((byte)((i1 >> 4 & 0x3) - 1));
            fe[7][1] = ((byte)((i1 >> 6 & 0x3) - 1));
            i1 = paramDataInputStream.readByte();
            fe[8][0] = ((byte)((i1 & 0x3) - 1));
            fe[8][1] = ((byte)((i1 >> 2 & 0x3) - 1));
            fe[9][0] = ((byte)((i1 >> 4 & 0x3) - 1));
            fe[10][0] = ((byte)((i1 >> 6 & 0x3) - 1));
            i1 = paramDataInputStream.readByte();
            fe[13][0] = ((byte)((i1 & 0x3) - 1));
            fe[14][0] = ((byte)((i1 >> 2 & 0x3) - 1));
            fe[15][0] = ((byte)((i1 >> 4 & 0x3) - 1));
            fe[15][1] = ((byte)((i1 >> 6 & 0x3) - 1));
            this.iC = paramDataInputStream.readByte();
            for (i1 = 0; i1 < this.hC.length; i1++)
            {
                this.hC[i1][0] = paramDataInputStream.readByte();
                this.hC[i1][1] = paramDataInputStream.readByte();
            }
            }
  
            public void B(DataOutputStream paramDataOutputStream) //throws Exception
            {
            paramDataOutputStream.writeInt(this.ke.size());
            if (this.ke.size() > 0) {
                for (int i2 = 0; i2 < this.ke.size(); i2++)
                {
                paramDataOutputStream.writeByte((byte)((D[])this.ke.elementAt(i2)).length);
                for (int i1 = 0; i1 < ((D[])this.ke.elementAt(i2)).length; i1++)
                {
                    D localD = ((D[])this.ke.elementAt(i2))[i1];
                    A(localD, paramDataOutputStream);
                }
                }
            }
            }
  
            public void B(DataInputStream paramDataInputStream) //throws Exception
            {
            this.ke = new Vector();
            int i4 = paramDataInputStream.readInt();
            if (i4 > 0) {
                for (int i3 = 0; i3 < i4; i3++)
                {
                int i2 = paramDataInputStream.readByte();
                D[] arrayOfD = new D[i2];
                for (int i1 = 0; i1 < i2; i1++) {
                    arrayOfD[i1] = A(paramDataInputStream, 0, 0, -1);
                }
                this.ke.addElement(arrayOfD);
                }
            }
            }
  
            public void C(DataOutputStream paramDataOutputStream) //throws Exception
            {
            for (int i3 = 0; i3 < this.wC; i3++) {
                for (int i2 = 0; i2 < this.vC; i2++)
                {
                A localA = this.ed[i3][i2];
                int i1 = 0;
                if (localA.i > 0) {
                    i1 = 1;
                }
                if ((localA.p != null ? 1 : 0) == 1) {
                    i1 = (byte)(i1 | 0x2);
                }
                if ((localA.q != null ? 1 : 0) == 1) {
                    i1 = (byte)(i1 | 0x4);
                }
                if (localA.w == true) {
                    i1 = (byte)(i1 | 0x8);
                }
                if (localA.x == true) {
                    i1 = (byte)(i1 | 0x10);
                }
                if (localA.d > 0) {
                    i1 = (byte)(i1 | localA.d << 5);
                }
                paramDataOutputStream.writeByte(i1);
                paramDataOutputStream.writeByte((byte)(localA.a | localA.b << 5));
                if (localA.i > 0) {
                    paramDataOutputStream.writeShort(localA.i);
                }
                if (localA.a >= 6)
                {
                    paramDataOutputStream.writeByte((byte)(localA.c | localA.e + 1 << 4));
                    paramDataOutputStream.writeShort(localA.m);
                    paramDataOutputStream.writeShort(localA.n);
                    paramDataOutputStream.writeShort(localA.k);
                    switch (localA.a)
                    {
                    case 6: 
                    case 7: 
                    case 8: 
                    case 9: 
                    case 10: 
                    case 15: 
                    paramDataOutputStream.writeShort(localA.l);
                    A(localA, null, paramDataOutputStream);
                    break;
                    case 13: 
                    paramDataOutputStream.writeShort(localA.l);
                    A(localA, null, paramDataOutputStream);
                    paramDataOutputStream.writeInt(localA.h[9]);
                    break;
                    case 12: 
                    paramDataOutputStream.writeShort(localA.l);
                    }
                }
                else
                {
                    switch (localA.a)
                    {
                    case 1: 
                    case 3: 
                    paramDataOutputStream.writeShort(localA.f[0]);
                    paramDataOutputStream.writeShort(localA.g[0]);
                    break;
                    case 4: 
                    case 5: 
                    for (i1 = 0; i1 < 3; i1++)
                    {
                        paramDataOutputStream.writeShort(localA.f[i1]);
                        paramDataOutputStream.writeShort(localA.g[i1]);
                    }
                    }
                }
                }
            }
            }
  
            public void A(DataInputStream paramDataInputStream, bool[][] paramArrayOfbool1, bool[][] paramArrayOfbool2, bool parambool) //throws Exception
            {
            for (int i4 = 0; i4 < this.wC; i4++) {
                for (int i3 = 0; i3 < this.vC; i3++)
                {
                A localA = new A();
                localA.t = ((byte)i3);
                localA.u = ((byte)i4);
                this.ed[i4][i3] = localA;
                int i1 = paramDataInputStream.readByte();
                int i2 = (i1 >> 0 & 0x1) == 1 ? 1 : 0;
                if (paramArrayOfbool1 != null) {
                    paramArrayOfbool1[i4][i3] = ((i1 >> 1 & 0x1) == 1 ? 1 : 0);
                }
                if (paramArrayOfbool2 != null) {
                    paramArrayOfbool2[i4][i3] = ((i1 >> 2 & 0x1) == 1 ? 1 : 0);
                }
                localA.w = ((i1 >> 3 & 0x1) == 1);
                localA.x = ((i1 >> 4 & 0x1) == 1);
                localA.d = ((byte)(i1 >> 5 & 0xF));
                i1 = paramDataInputStream.readByte();
                localA.a = ((byte)(i1 & 0x1F));
                if (parambool) {
                    localA.b = 1;
                } else {
                    localA.b = ((byte)(i1 >> 5 & 0x7));
                }
                if (i2 != 0)
                {
                    localA.i = paramDataInputStream.readShort();
                    if (parambool) {
                    localA.i = ((short)(localA.i * 100));
                    }
                    if (localA.a >= 6)
                    {
                    if (localA.d == 0) {
                        A(localA.i, 8, localA.t, localA.u, 0, -24, 48, 36, 0, 6, 0, 2);
                    } else if (localA.d == 1) {
                        A(localA.i, 8, localA.t, localA.u, 0, -24, 48, 36, 0, 8, 0, 2);
                    } else {
                        A(localA.i, 8, localA.t, localA.u, 0, -24, 48, 36, 0, 6, 0, 2);
                    }
                    }
                    else {
                    A(localA.i, 4, localA.t, localA.u, 0, -24, 48, 36, 0, 10, 0, 2);
                    }
                }
                if (localA.a >= 6)
                {
                    i1 = paramDataInputStream.readByte();
                    localA.c = ((byte)(i1 & 0xF));
                    localA.e = ((byte)((byte)(i1 >> 4 & 0xF) - 1));
                    if (localA.e == -1) {
                    localA.j = 0;
                    } else {
                    localA.j = 20;
                    }
                    if (parambool)
                    {
                    localA.m = 0;
                    localA.n = 0;
                    localA.k = 0;
                    }
                    else
                    {
                    localA.m = paramDataInputStream.readShort();
                    localA.n = paramDataInputStream.readShort();
                    localA.k = paramDataInputStream.readShort();
                    }
                    switch (localA.a)
                    {
                    case 6: 
                    case 7: 
                    case 8: 
                    case 9: 
                    case 10: 
                    case 15: 
                    if (parambool) {
                        localA.l = 0;
                    } else {
                        localA.l = paramDataInputStream.readShort();
                    }
                    A(localA, null, paramDataInputStream);
                    break;
                    case 13: 
                    if (parambool) {
                        localA.l = 0;
                    } else {
                        localA.l = paramDataInputStream.readShort();
                    }
                    A(localA, null, paramDataInputStream);
                    localA.h[9] = paramDataInputStream.readInt();
                    break;
                    case 12: 
                    if (parambool) {
                        localA.l = 0;
                    } else {
                        localA.l = paramDataInputStream.readShort();
                    }
                    break;
                    }
                }
                else
                {
                    switch (localA.a)
                    {
                    case 1: 
                    case 3: 
                    localA.f[0] = paramDataInputStream.readShort();
                    if (parambool) {
                        localA.g[0] = localA.f[0];
                    } else {
                        localA.g[0] = paramDataInputStream.readShort();
                    }
                    i1 = 1;
                    case 4: 
                    case 5: 
                    while (i1 < 3)
                    {
                        localA.g[i1] = 0;
                        localA.f[i1] = 0;
                        i1++;
                        continue;
                        for (i1 = 0; i1 < 3; i1++)
                        {
                        localA.f[i1] = paramDataInputStream.readShort();
                        if (parambool) {
                            localA.g[i1] = localA.f[i1];
                        } else {
                            localA.g[i1] = paramDataInputStream.readShort();
                        }
                        }
                    }
                    }
                }
                if (this.ed[i4][i3].a == 13)
                {
                    this.cc = this.ed[i4][i3];
                    D(this.cc.t, this.cc.u);
                }
                }
            }
            }
  
            public void D(DataOutputStream paramDataOutputStream) //throws Exception
            {
            for (int i2 = 0; i2 < this.wC; i2++) {
                for (int i1 = 0; i1 < this.vC; i1++)
                {
                D localD;
                if (this.ed[i2][i1].p != null)
                {
                    localD = this.ed[i2][i1].p;
                    A(localD, paramDataOutputStream);
                }
                if (this.ed[i2][i1].q != null)
                {
                    localD = this.ed[i2][i1].q;
                    A(localD, paramDataOutputStream);
                }
                }
            }
            }
  
            public void A(DataInputStream paramDataInputStream, bool[][] paramArrayOfbool1, bool[][] paramArrayOfbool2) //throws Exception
            {
            for (int i2 = 0; i2 < this.wC; i2++) {
                for (int i1 = 0; i1 < this.vC; i1++)
                {
                A(this.ed[i2][i1]);
                if (paramArrayOfbool1[i2][i1] != 0) {
                    this.ed[i2][i1].p = A(paramDataInputStream, i1, i2, 0);
                }
                if (paramArrayOfbool2[i2][i1] != 0) {
                    this.ed[i2][i1].q = A(paramDataInputStream, i1, i2, 1);
                }
                }
            }
            }
  
            public void E(DataOutputStream paramDataOutputStream) //throws Exception
            {
            int i2 = this.od.size();
            int i1 = 0;
            paramDataOutputStream.writeByte((byte)i2);
            while (i1 < i2)
            {
                A((D)this.od.elementAt(i1), paramDataOutputStream);
                i1++;
            }
            }
  
            public void C(DataInputStream paramDataInputStream) //throws Exception
            {
            this.od = new Vector();
            int i2 = paramDataInputStream.readByte();
            for (int i1 = 0; i1 < i2; i1++)
            {
                D localD = A(paramDataInputStream, 0, 0, -1);
                this.od.addElement(localD);
            }
            }
  
            public void F(DataOutputStream paramDataOutputStream) //throws Exception
            {
            int i2 = this.rd.size();
            int i1 = 0;
            paramDataOutputStream.writeByte((byte)i2);
            while (i1 < i2)
            {
                A((D)this.rd.elementAt(i1), paramDataOutputStream);
                i1++;
            }
            }
  
            public void D(DataInputStream paramDataInputStream) //throws Exception
            {
            this.rd = new Vector();
            int i2 = paramDataInputStream.readByte();
            for (int i1 = 0; i1 < i2; i1++)
            {
                D localD = A(paramDataInputStream, 0, 0, -1);
                this.rd.addElement(localD);
            }
            }
  
            public void A(A paramA, D paramD, DataOutputStream paramDataOutputStream) //throws Exception
            {
            int[] arrayOfInt;
            if (paramD != null) {
                arrayOfInt = paramD.g;
            } else {
                arrayOfInt = paramA.h;
            }
            paramD = 0;
            for (this = 0; this < 8; this++) {
                if (arrayOfInt[this] > 0) {
                paramD = (byte)(paramD | 1 << this);
                }
            }
            paramDataOutputStream.writeByte(paramD);
            paramD = 0;
            for (this = 8; this < 14; this++) {
                if ((arrayOfInt[this] > 0) && ((this != 9) || (paramA.a == 10))) {
                paramD = (byte)(paramD | 1 << this - 8);
                }
            }
            paramDataOutputStream.writeByte(paramD);
            paramD = "resources: [ ";
            for (this = 0; this < 14; this++) {
                if ((arrayOfInt[this] > 0) && ((this != 9) || (paramA.a == 10)))
                {
                paramDataOutputStream.writeByte((byte)arrayOfInt[this]);
                paramD = paramD + arrayOfInt[this] + " ";
                }
            }
            new StringBuffer().append(paramD).append("] ").toString();
            }
  
            public void A(A paramA, D paramD, DataInputStream paramDataInputStream) //throws Exception
            {
            int[] arrayOfInt = new int[14];
            this = new bool[14];
            int i2 = paramDataInputStream.readByte();
            for (int i1 = 0; i1 < 8; i1++) {
                if ((i2 >> i1 & 0x1) == 1) {
                this[i1] = 1;
                } else {
                this[i1] = 0;
                }
            }
            i2 = paramDataInputStream.readByte();
            for (i1 = 8; i1 < 14; i1++) {
                if ((i2 >> i1 - 8 & 0x1) == 1) {
                this[i1] = 1;
                } else {
                this[i1] = 0;
                }
            }
            if ((paramA != null) && (paramA.a != 10)) {
                this[9] = 0;
            }
            for (i1 = 0; i1 < 14; i1++) {
                if (this[i1] != 0) {
                arrayOfInt[i1] = paramDataInputStream.readByte();
                } else {
                arrayOfInt[i1] = 0;
                }
            }
            String str2 = "have_resource: [ ";
            String str1 = "resources: [ ";
            for (paramDataInputStream = 0; paramDataInputStream < 14; paramDataInputStream++)
            {
                if (this[paramDataInputStream] != 0) {
                str2 = str2 + "t ";
                } else {
                str2 = str2 + "f ";
                }
                str1 = str1 + arrayOfInt[paramDataInputStream] + " ";
            }
            new StringBuffer().append(str2).append("] ").toString();
            new StringBuffer().append(str1).append("] ").toString();
            if (paramD != null) {
                paramD.g = arrayOfInt;
            } else {
                paramA.h = arrayOfInt;
            }
            }
  
            public void A(D paramD, DataOutputStream paramDataOutputStream) //throws Exception
            {
            if (((paramD.c == 0) && (paramD.d == 1)) || ((paramD.c == 1) && (paramD.d == 3)))
            {
                paramDataOutputStream.writeByte(1);
            }
            else
            {
                paramDataOutputStream.writeByte(0);
                paramDataOutputStream.writeByte(paramD.f == null ? 0 : 1);
                paramDataOutputStream.writeByte(paramD.c);
                paramDataOutputStream.writeByte(paramD.d);
                paramDataOutputStream.writeByte(paramD.e.t);
                paramDataOutputStream.writeByte(paramD.e.u);
                if (paramD.f != null)
                {
                paramDataOutputStream.writeByte(paramD.f.t);
                paramDataOutputStream.writeByte(paramD.f.u);
                }
                paramDataOutputStream.writeByte(paramD.h);
                paramDataOutputStream.writeByte(paramD.i);
                paramDataOutputStream.writeByte(paramD.j);
                paramDataOutputStream.writeByte(paramD.k);
                paramDataOutputStream.writeByte(paramD.l);
                paramDataOutputStream.writeByte(paramD.m);
                paramDataOutputStream.writeByte((byte)(paramD.n | paramD.v + 1 << 4));
                paramDataOutputStream.writeByte(paramD.o);
                paramDataOutputStream.writeShort(paramD.y);
                paramDataOutputStream.writeByte(paramD.z);
                paramDataOutputStream.writeByte((byte)(paramD.w | (paramD.aa ? 1 : 0) << 4));
                if ((paramD.c != 17) && (paramD.c != 18) && (paramD.c != 19))
                {
                paramDataOutputStream.writeByte((byte)paramD.x);
                A(null, paramD, paramDataOutputStream);
                }
                else if (paramD.c == 19)
                {
                if (paramD.ba) {
                    paramDataOutputStream.writeByte(1);
                } else {
                    paramDataOutputStream.writeByte(0);
                }
                }
                else
                {
                paramDataOutputStream.writeShort(paramD.ca);
                }
            }
            }
  
            public D A(DataInputStream paramDataInputStream, int paramInt1, int paramInt2, int paramInt3) //throws Exception
            {
            D localD = null;
            byte b1 = paramDataInputStream.readByte();
            if (b1 == 0)
            {
                paramInt3 = paramDataInputStream.readByte();
                paramInt3 = paramInt3 == 1 ? 1 : 0;
                b1 = paramDataInputStream.readByte();
                if (b1 == 0) {
                localD = this.ed[paramInt2][paramInt1].p;
                } else if (b1 == 1) {
                localD = this.ed[paramInt2][paramInt1].q;
                } else {
                localD = new D(this, b1);
                }
                localD.d = paramDataInputStream.readByte();
                paramInt2 = paramDataInputStream.readByte();
                paramInt1 = paramDataInputStream.readByte();
                localD.e = this.ed[paramInt1][paramInt2];
                if (paramInt3 != 0)
                {
                paramInt2 = paramDataInputStream.readByte();
                paramInt1 = paramDataInputStream.readByte();
                localD.f = this.ed[paramInt1][paramInt2];
                }
                paramInt2 = paramDataInputStream.readByte();
                paramInt1 = paramDataInputStream.readByte();
                localD.A(paramInt2, paramInt1);
                localD.j = paramDataInputStream.readByte();
                localD.k = paramDataInputStream.readByte();
                localD.l = paramDataInputStream.readByte();
                localD.m = paramDataInputStream.readByte();
                paramInt1 = paramDataInputStream.readByte();
                localD.n = ((byte)(paramInt1 & 0xF));
                localD.v = ((byte)((paramInt1 >> 4 & 0xF) - 1));
                localD.o = paramDataInputStream.readByte();
                localD.y = paramDataInputStream.readShort();
                localD.z = paramDataInputStream.readByte();
                paramInt1 = paramDataInputStream.readByte();
                localD.w = ((byte)(paramInt1 & 0xF));
                localD.aa = ((paramInt1 >> 4 & 0xF) == 1);
                if ((localD.c != 17) && (localD.c != 18) && (localD.c != 19))
                {
                localD.x = ((short)paramDataInputStream.readByte());
                A(null, localD, paramDataInputStream);
                }
                else if (localD.c == 19)
                {
                if (paramDataInputStream.readByte() == 1) {
                    localD.ba = true;
                } else {
                    localD.ba = false;
                }
                }
                else
                {
                localD.ca = paramDataInputStream.readShort();
                }
            }
            else if (paramInt3 == 0)
            {
                localD = this.ed[paramInt2][paramInt1].p;
                if (localD != null) {}
            }
            else if (paramInt3 == 1)
            {
                localD = this.ed[paramInt2][paramInt1].q;
            }
            if (localD.c == 17) {
                localD.t = 38;
            } else if (localD.c == 18) {
                localD.t = 39;
            } else if ((localD.c != 0) && (localD.c != 1)) {
                localD.t = 26;
            } else if ((localD.c == 0) && (localD.d == 3)) {
                if (localD.e.a == 13) {
                localD.t = 29;
                } else {
                localD.t = 27;
                }
            }
            return localD;
            }
  
            public void G(DataOutputStream paramDataOutputStream) //throws Exception
            {
            paramDataOutputStream.writeShort(this.ae);
            paramDataOutputStream.writeByte(this.be);
            paramDataOutputStream.writeByte(3);
            for (int i1 = 0; i1 < 3; i1++)
            {
                paramDataOutputStream.writeShort((short)this.ce[i1][1]);
                if (this.ce[i1][1] > 0)
                {
                paramDataOutputStream.writeByte((byte)this.ce[i1][0]);
                paramDataOutputStream.writeShort((short)this.ce[i1][2]);
                paramDataOutputStream.writeByte((byte)this.ce[i1][3]);
                paramDataOutputStream.writeInt(this.ce[i1][4]);
                paramDataOutputStream.writeByte((byte)this.ce[i1][5]);
                paramDataOutputStream.writeByte((byte)this.ce[i1][6]);
                paramDataOutputStream.writeShort((short)this.ce[i1][7]);
                if (this.de[i1] != null)
                {
                    paramDataOutputStream.writeByte(this.de[i1].t);
                    paramDataOutputStream.writeByte(this.de[i1].u);
                }
                else
                {
                    paramDataOutputStream.writeByte(127);
                    paramDataOutputStream.writeByte(127);
                }
                }
            }
            }
  
            public void E(DataInputStream paramDataInputStream) //throws Exception
            {
            this.ae = paramDataInputStream.readShort();
            this.be = paramDataInputStream.readByte();
            int i4 = paramDataInputStream.readByte();
            for (int i3 = 0; i3 < i4; i3++)
            {
                this.ce[i3][1] = paramDataInputStream.readShort();
                if (this.ce[i3][1] > 0)
                {
                this.ce[i3][0] = paramDataInputStream.readByte();
                this.ce[i3][2] = paramDataInputStream.readShort();
                this.ce[i3][3] = paramDataInputStream.readByte();
                this.ce[i3][4] = paramDataInputStream.readInt();
                this.ce[i3][5] = paramDataInputStream.readByte();
                this.ce[i3][6] = paramDataInputStream.readByte();
                this.ce[i3][7] = paramDataInputStream.readShort();
                int i2 = paramDataInputStream.readByte();
                int i1 = paramDataInputStream.readByte();
                if ((i2 == 127) && (i1 == 127)) {
                    this.de[i3] = null;
                } else {
                    this.de[i3] = this.ed[i1][i2];
                }
                }
            }
            }
  
            public void F(DataInputStream paramDataInputStream) //throws Exception
            {
            this.jC = new Vector();
            this.kC = new Vector();
            this.lC = new Vector();
            this.mC = new Vector();
            this.nC = new Vector();
            this.oC = new Vector();
            this.pC = new Vector();
            this.qC = new Vector();
            this.rC = new Vector();
            this.sC = new Vector();
            this.tC = new Vector();
            this.uC = new Vector();
            int i4 = paramDataInputStream.readByte();
            for (int i3 = 0; i3 < i4; i3++)
            {
                Vector localVector3 = new Vector();
                Vector localVector1 = new Vector();
                int i2 = paramDataInputStream.readByte();
                Vector localVector2;
                if (i2 != -1)
                {
                short[] arrayOfShort;
                int i1;
                while (i2 > 0)
                {
                    arrayOfShort = new short[4];
                    arrayOfShort[0] = 0;
                    i1 = (byte)paramDataInputStream.read();
                    arrayOfShort[1] = ((short)(i1 & 0xF));
                    arrayOfShort[3] = ((short)(i1 >> 4 & 0xF));
                    if (arrayOfShort[1] != 9) {
                    arrayOfShort[2] = ((short)paramDataInputStream.readByte());
                    } else {
                    arrayOfShort[2] = paramDataInputStream.readShort();
                    }
                    localVector3.addElement(arrayOfShort);
                    i2--;
                }
                for (i2 = paramDataInputStream.readByte(); i2 > 0; i2--)
                {
                    arrayOfShort = new short[5];
                    arrayOfShort[0] = 1;
                    i1 = (byte)paramDataInputStream.read();
                    arrayOfShort[1] = ((short)(i1 & 0xF));
                    arrayOfShort[3] = ((short)(i1 >> 4 & 0xF));
                    i1 = (byte)paramDataInputStream.read();
                    arrayOfShort[2] = ((short)(i1 & 0x3F));
                    arrayOfShort[4] = ((short)(i1 >> 6 & 0x3));
                    localVector3.addElement(arrayOfShort);
                }
                for (i2 = paramDataInputStream.readByte(); i2 > 0; i2--)
                {
                    arrayOfShort = new short[4];
                    arrayOfShort[0] = 2;
                    i1 = (byte)paramDataInputStream.read();
                    arrayOfShort[1] = ((short)(i1 & 0xF));
                    arrayOfShort[3] = ((short)(i1 >> 4 & 0xF));
                    if (arrayOfShort[1] != 0) {
                    arrayOfShort[2] = ((short)paramDataInputStream.readByte());
                    } else {
                    arrayOfShort[2] = paramDataInputStream.readShort();
                    }
                    localVector3.addElement(arrayOfShort);
                }
                localVector2 = G(paramDataInputStream);
                }
                if (i3 == 0)
                {
                this.jC = localVector3;
                this.lC = localVector2;
                }
                else if (i3 == 1)
                {
                this.kC = localVector3;
                this.mC = localVector2;
                }
                else if (i3 == 2)
                {
                this.nC = localVector3;
                this.pC = localVector2;
                }
                else if (i3 == 3)
                {
                this.oC = localVector3;
                this.qC = localVector2;
                }
                else if (i3 % 2 == 0)
                {
                this.rC.addElement(localVector3);
                this.tC.addElement(localVector2);
                }
                else
                {
                this.sC.addElement(localVector3);
                this.uC.addElement(localVector2);
                }
            }
            }
  
            public Vector G(DataInputStream paramDataInputStream) //throws Exception
            {
            Vector localVector = new Vector();
            short[] arrayOfShort = null;
            for (int i2 = paramDataInputStream.readByte(); i2 > 0; i2--)
            {
                int i1 = (byte)paramDataInputStream.read();
                this = (short)(i1 & 0x7);
                if (this == 0)
                {
                arrayOfShort = new short[2];
                arrayOfShort[0] = this;
                arrayOfShort[1] = ((short)(i1 >> 3 & 0xF));
                }
                else if (this == 1)
                {
                arrayOfShort = new short[3];
                arrayOfShort[0] = this;
                arrayOfShort[1] = ((short)(i1 >> 3 & 0xF));
                arrayOfShort[2] = paramDataInputStream.readShort();
                }
                else if (this == 2)
                {
                arrayOfShort = new short[4];
                arrayOfShort[0] = this;
                arrayOfShort[1] = 0;
                arrayOfShort[3] = ((short)(i1 >> 3 & 0x3));
                arrayOfShort[2] = ((short)paramDataInputStream.readByte());
                }
                else if (this == 3)
                {
                arrayOfShort = new short[18];
                arrayOfShort[0] = this;
                arrayOfShort[1] = 0;
                arrayOfShort[2] = 0;
                arrayOfShort[3] = ((short)(i1 >> 3 & 0x3));
                arrayOfShort[13] = paramDataInputStream.readShort();
                arrayOfShort[4] = ((short)paramDataInputStream.readByte());
                arrayOfShort[5] = ((short)paramDataInputStream.readByte());
                arrayOfShort[6] = ((short)paramDataInputStream.readByte());
                arrayOfShort[7] = ((short)paramDataInputStream.readByte());
                arrayOfShort[8] = ((short)paramDataInputStream.readByte());
                arrayOfShort[9] = ((short)paramDataInputStream.readByte());
                arrayOfShort[10] = ((short)paramDataInputStream.readByte());
                arrayOfShort[11] = ((short)paramDataInputStream.readByte());
                arrayOfShort[12] = ((short)paramDataInputStream.readByte());
                arrayOfShort[14] = ((short)paramDataInputStream.readByte());
                arrayOfShort[15] = ((short)paramDataInputStream.readByte());
                arrayOfShort[16] = ((short)paramDataInputStream.readByte());
                arrayOfShort[17] = ((short)paramDataInputStream.readByte());
                }
                else if (this == 4)
                {
                arrayOfShort = new short[23];
                arrayOfShort[0] = this;
                arrayOfShort[1] = 0;
                arrayOfShort[2] = 0;
                this = (byte)paramDataInputStream.read();
                arrayOfShort[3] = ((short)((this & 0x3) - 1));
                arrayOfShort[4] = ((short)((this >> 2 & 0x3) - 1));
                arrayOfShort[5] = ((short)((this >> 4 & 0x3) - 1));
                arrayOfShort[6] = ((short)((this >> 6 & 0x3) - 1));
                this = (byte)paramDataInputStream.read();
                arrayOfShort[7] = ((short)((this & 0x3) - 1));
                arrayOfShort[8] = ((short)((this >> 2 & 0x3) - 1));
                arrayOfShort[9] = ((short)((this >> 4 & 0x3) - 1));
                arrayOfShort[10] = ((short)((this >> 6 & 0x3) - 1));
                this = (byte)paramDataInputStream.read();
                arrayOfShort[11] = ((short)((this & 0x3) - 1));
                arrayOfShort[12] = ((short)((this >> 2 & 0x3) - 1));
                arrayOfShort[13] = 0;
                arrayOfShort[14] = -1;
                arrayOfShort[15] = 0;
                arrayOfShort[16] = -1;
                arrayOfShort[17] = ((short)((this >> 4 & 0x3) - 1));
                arrayOfShort[18] = ((short)((this >> 6 & 0x3) - 1));
                this = (byte)paramDataInputStream.read();
                arrayOfShort[19] = ((short)((this & 0x3) - 1));
                arrayOfShort[20] = ((short)((this >> 2 & 0x3) - 1));
                arrayOfShort[21] = ((short)((this >> 4 & 0x3) - 1));
                arrayOfShort[22] = ((short)((this >> 6 & 0x3) - 1));
                }
                else if (this == 5)
                {
                arrayOfShort = new short[3];
                arrayOfShort[0] = this;
                arrayOfShort[1] = ((short)(i1 >> 3 & 0xF));
                arrayOfShort[2] = ((short)(i1 >> 7 & 0x1));
                }
                else if (this == 6)
                {
                arrayOfShort = new short[2];
                arrayOfShort[0] = this;
                arrayOfShort[1] = ((short)(i1 >> 3 & 0xF));
                arrayOfShort[1] = ((short)(arrayOfShort[1] * 5));
                }
                else if (this == 7)
                {
                arrayOfShort = new short[3];
                arrayOfShort[0] = this;
                arrayOfShort[1] = ((short)(i1 >> 3 & 0xF));
                arrayOfShort[2] = ((short)paramDataInputStream.readByte());
                }
                localVector.addElement(arrayOfShort);
            }
            return localVector;
            }
  
            public static int G(int paramInt1, int paramInt2)
            {
            if (paramInt2 < paramInt1)
            {
                int i1 = paramInt1;
                paramInt1 = paramInt2;
                paramInt2 = i1;
            }
            paramInt2 = Math.abs(paramInt2 - paramInt1 + 1);
            if (paramInt2 == 0) {
                return 0;
            }
            return paramInt1 + Math.abs(zb.nextInt()) % paramInt2;
            }
  
            public int A(int paramInt1, int paramInt2, int paramInt3, int paramInt4)
            {
            int i3 = paramInt3 - paramInt1;
            int i2 = paramInt4 - paramInt2;
            int i1 = 0;
            while ((i3 != 0) || (i2 != 0))
            {
                if (i3 >= 0) {
                this = 1;
                } else {
                this = 0;
                }
                if ((i3 == 0) && ((paramInt2 & 0x1) > 0)) {
                this = 0;
                }
                if (i2 < 0) {
                i2 = 2;
                } else if (i2 == 0)
                {
                if (paramInt2 == 0) {
                    i2 = 3;
                } else {
                    i2 = 2;
                }
                }
                else {
                i2 = 3;
                }
                if (i2 == 2)
                {
                if (this == 0)
                {
                    if ((paramInt2 & 0x1) == 0) {
                    paramInt1--;
                    }
                    paramInt2--;
                }
                else
                {
                    if ((paramInt2 & 0x1) > 0) {
                    paramInt1++;
                    }
                    paramInt2--;
                }
                }
                else if (i2 == 3) {
                if (this == 0)
                {
                    if ((paramInt2 & 0x1) == 0) {
                    paramInt1--;
                    }
                    paramInt2++;
                }
                else
                {
                    if ((paramInt2 & 0x1) > 0) {
                    paramInt1++;
                    }
                    paramInt2++;
                }
                }
                i1++;
                i3 = paramInt3 - paramInt1;
                i2 = paramInt4 - paramInt2;
            }
            return i1;
            }
  
            public int D(A paramA)
            {
            if (paramA.e == -1) {
                return 16;
            }
            switch (paramA.a)
            {
            case 11: 
                return 6;
            case 12: 
                return this.nd[paramA.e];
            case 13: 
                return 9;
            case 14: 
                return 8;
            case 10: 
                return 5;
            }
            paramA = sa[(paramA.a * 3 + paramA.e)];
            if (paramA != -1) {
                return this.nd[paramA];
            }
            return -1;
            }
  
            public void PB()
            {
            if ((!this.zB) && (!this.ac)) {
                return;
            }
            if ((this.pd != null) && (this.pd.d == 3)) {
                this.pd = null;
            }
            if (this.qd > 0)
            {
                this.qd -= 1;
            }
            else
            {
                int i6 = 0;
                int i4 = G(0, 1);
                if ((i4 == 1) && (!this.ac))
                {
                i4 = 0;
                i6 = 80 - this.qB;
                }
                else if ((i4 == 0) && (!this.zB))
                {
                i4 = 1;
                i6 = 80;
                }
                else if (i4 == 0)
                {
                i6 = 80 - this.qB;
                }
                else if (i4 == 1)
                {
                i6 = 80;
                }
                label637:
                Object localObject5;
                Object localObject2;
                if (i6 > 0)
                {
                if (i6 >= G(1, 100))
                {
                    Object localObject4;
                    if (i4 == 0)
                    {
                    int i1 = G(0, 2);
                    localObject4 = A(11, false, -1);
                    Object localObject1;
                    if (((Vector)localObject4).size() == 0)
                    {
                        localObject1 = A(G(0, this.vC), G(0, this.wC), 0, -1, false);
                        if (localObject1 != null)
                        {
                        A((A)localObject1, 11);
                        D(((A)localObject1).t, ((A)localObject1).u);
                        H(0, 147);
                        this.yc = true;
                        }
                    }
                    else
                    {
                        switch (localObject1)
                        {
                        case 0: 
                        if (this.qB > 50)
                        {
                            localObject1 = (A)((Vector)localObject4).elementAt(G(0, ((Vector)localObject4).size() - 1));
                            if ((((A)localObject1).c < 2) && (((A)localObject1).i == 0))
                            {
                            G((A)localObject1);
                            D(((A)localObject1).t, ((A)localObject1).u);
                            H(0, 148);
                            this.yc = true;
                            break label637;
                            }
                        }
                        else
                        {
                            localObject1 = (A)((Vector)localObject4).elementAt(G(0, ((Vector)localObject4).size() - 1));
                            if (((A)localObject1).c != 0)
                            {
                            A((A)localObject1, true);
                            D(((A)localObject1).t, ((A)localObject1).u);
                            H(0, 146);
                            this.yc = true;
                            }
                        }
                        break;
                        case 1: 
                        localObject1 = A(12, false, -1);
                        if ((localObject1 != null) && (((Vector)localObject1).size() > 0)) {
                            if (this.qB > 70)
                            {
                            localObject1 = (A)((Vector)localObject1).elementAt(G(0, ((Vector)localObject1).size() - 1));
                            if ((((A)localObject1).c < 2) && (((A)localObject1).i == 0))
                            {
                                G((A)localObject1);
                                D(((A)localObject1).t, ((A)localObject1).u);
                                H(0, 145);
                                this.yc = true;
                                break label637;
                            }
                            }
                            else
                            {
                            localObject1 = (A)((Vector)localObject1).elementAt(G(0, ((Vector)localObject1).size() - 1));
                            A((A)localObject1, true);
                            D(((A)localObject1).t, ((A)localObject1).u);
                            H(0, 143);
                            this.yc = true;
                            }
                        }
                        break;
                        case 2: 
                        if ((localObject4 != null) && (((Vector)localObject4).size() > 0))
                        {
                            localObject4 = (A)((Vector)localObject4).elementAt(G(0, ((Vector)localObject4).size() - 1));
                            localObject1 = A(((A)localObject4).t, ((A)localObject4).u, 17, -1, false);
                            if ((localObject1 != null) && (this.pd == null))
                            {
                            this.pd = new D(this, 17, (A)localObject4, (A)localObject1);
                            this.pd.G();
                            this.od.addElement(this.pd);
                            }
                        }
                        break;
                        }
                    }
                    }
                    else
                    {
                    localObject5 = A(20, false, -1);
                    localObject4 = null;
                    if ((localObject5 != null) && (((Vector)localObject5).size() > 0))
                    {
                        for (int i2 = 0; i2 < ((Vector)localObject5).size(); i2++) {
                        if (((A)((Vector)localObject5).elementAt(i2)).x)
                        {
                            localObject4 = (A)((Vector)localObject5).elementAt(i2);
                            break;
                        }
                        }
                        if (localObject4 != null)
                        {
                        localObject2 = A(((A)localObject4).t, ((A)localObject4).u, 17, -1, false);
                        if ((localObject2 != null) && (this.pd == null))
                        {
                            this.pd = new D(this, 18, (A)localObject4, (A)localObject2);
                            this.pd.G();
                            this.od.addElement(this.pd);
                        }
                        }
                    }
                    }
                }
                }
                else
                {
                int i5 = G(0, 2);
                localObject2 = A(11, false, -1);
                if (((Vector)localObject2).size() == 0)
                {
                    localObject2 = A(G(0, this.vC), G(0, this.wC), 0, -1, false);
                    if (localObject2 != null)
                    {
                    A((A)localObject2, 11);
                    D(((A)localObject2).t, ((A)localObject2).u);
                    H(0, 147);
                    this.yc = true;
                    }
                }
                else
                {
                    Object localObject3;
                    switch (i5)
                    {
                    case 0: 
                    localObject2 = A(11, false, -1);
                    if ((localObject2 != null) && (((Vector)localObject2).size() > 0))
                    {
                        localObject2 = (A)((Vector)localObject2).elementAt(G(0, ((Vector)localObject2).size() - 1));
                        if ((((A)localObject2).c < 2) && (((A)localObject2).i == 0))
                        {
                        G((A)localObject2);
                        D(((A)localObject2).t, ((A)localObject2).u);
                        H(0, 148);
                        this.yc = true;
                        }
                    }
                    break;
                    case 1: 
                    Vector localVector2 = A(12, false, -1);
                    if (localVector2 != null) {
                        if (G(0, 1) == 0)
                        {
                        if (localVector2.size() < 5)
                        {
                            localObject5 = A(G(0, this.vC), G(0, this.wC), 0, -1, false);
                            if (localObject5 != null)
                            {
                            A((A)localObject5, 12);
                            i5 = 1;
                            if (i5 != 0)
                            {
                                ((A)localObject5).e = ((byte)G(0, 13));
                                i5 = 0;
                                for (int i3 = 0; i3 < localVector2.size(); i3++) {
                                if ((((A)localVector2.elementAt(i3)).e == ((A)localObject5).e) || (((A)localObject5).e == 9)) {
                                    i5 = 1;
                                }
                                }
                            }
                            D(((A)localObject5).t, ((A)localObject5).u);
                            H(0, 144);
                            this.yc = true;
                            break label1324;
                            }
                        }
                        }
                        else if (localVector2.size() > 0)
                        {
                        localObject3 = (A)localVector2.elementAt(G(0, localVector2.size() - 1));
                        if ((((A)localObject3).c < 2) && (((A)localObject3).i == 0))
                        {
                            G((A)localObject3);
                            D(((A)localObject3).t, ((A)localObject3).u);
                            H(0, 145);
                            this.yc = true;
                        }
                        }
                    }
                    break;
                    case 2: 
                    Vector localVector1 = A(18, false, -1);
                    localObject3 = A(19, false, -1);
                    if ((((Vector)localObject3).size() > 0) && (localVector1.size() > 0))
                    {
                        localObject3 = (A)localVector1.elementAt(G(0, localVector1.size() - 1));
                        localObject3 = A(((A)localObject3).t, ((A)localObject3).u, 19, -1, false);
                        if ((localObject3 != null) && (!((A)localObject3).x))
                        {
                        ((A)localObject3).w = false;
                        ((A)localObject3).x = false;
                        D(((A)localObject3).t, ((A)localObject3).u);
                        H(0, 141);
                        this.yc = true;
                        }
                    }
                    break;
                    }
                }
                }
                label1324:
                this.qd = 1000;
            }
            }
        
        public void A(int paramInt1, int[] paramArrayOfInt1, int paramInt2, int[] paramArrayOfInt2, String paramString)
            {
            if ((paramInt1 != 5) && (paramInt1 != 9)) {
                this.nD = true;
            }
            this.wd = paramInt1;
            this.xd = paramArrayOfInt1;
            this.yd = paramInt2;
            this.zd = paramArrayOfInt2;
            this.aD = paramString;
            if (this.aD != null) {
                UB();
            }
            R();
            U();
            PA();
            if (this.n != 203) {
                K(203);
            }
            if (this.yd != -1) {
                U(this.yd);
            }
            if (this.ed[this.jd][this.id].w) {
                U(38);
            }
            paramInt1 = 0;
            if (this.ee != -1) {
                paramInt1 = this.ce[this.ee][0];
            }
            if ((this.zd != null) && (this.wd == 11) && (paramInt1 != 0) && (paramInt1 != 1) && (paramInt1 != 4) && (paramInt1 != 9)) {
                for (paramInt1 = 0; paramInt1 < this.zd.length; paramInt1++) {
                if (this.zd[paramInt1] != 99) {
                    U(this.gd[(this.zd[paramInt1] * 2 + 1)]);
                }
                }
            }
            S();
            }
  
            int QB()
            {
            this = 13 * ba[(this.cc.a - 6)][0][this.cc.c];
            return this;
            }
  
        int RB()
        {
            int i2 = 0;
            for (int i1 = 0; i1 < 14; i1++) {
                i2 += this.cc.h[i1];
            }
            this = i2 - this.cc.h[9];
            return this;
        }
  
            void F(A paramA)
            {
            for (int i1 = 0; i1 < 14; i1++) {
                if (i1 == 9) {
                this.cc.h[i1] += ea[(paramA.a - 6)][paramA.c][i1] / 2;
                } else if (ba[(this.cc.a - 6)][i1][this.cc.c] > this.cc.h[i1] + ea[(paramA.a - 6)][paramA.c][i1] / 2) {
                this.cc.h[i1] += ea[(paramA.a - 6)][paramA.c][i1] / 2;
                } else {
                this.cc.h[i1] = ba[(this.cc.a - 6)][i1][this.cc.c];
                }
            }
            }
  
            void A(int paramInt1, int[] paramArrayOfInt1, int[] paramArrayOfInt2, String paramString, int paramInt2)
            {
            paramArrayOfInt1 = new int[10];
            paramArrayOfInt1[0] = 12;
            paramArrayOfInt1[1] = paramInt2;
            paramArrayOfInt1[2] = 5;
            paramArrayOfInt1[3] = 106;
            paramArrayOfInt1[4] = 6;
            paramArrayOfInt1[5] = 107;
            paramArrayOfInt1[6] = 13;
            paramArrayOfInt1[7] = paramInt2;
            paramArrayOfInt1[8] = 10;
            paramArrayOfInt1[9] = 111;
            paramArrayOfInt2 = new int[6];
            paramArrayOfInt2[0] = ja[paramInt1];
            paramArrayOfInt2[1] = this.cc.h[paramInt1];
            paramArrayOfInt2[2] = paramInt1;
            paramArrayOfInt2[3] = 15;
            paramArrayOfInt2[4] = this.cc.h[9];
            paramArrayOfInt2[5] = 9;
            this.kD = D(108);
            if (this.cc.h[paramInt1] == ba[(this.cc.a - 6)][paramInt1][this.cc.c]) {
                A(7, paramArrayOfInt1, -1, paramArrayOfInt2, D(115));
            } else {
                A(7, paramArrayOfInt1, -1, paramArrayOfInt2, null);
            }
            }
  
            void UB()
            {
            int i1 = yb.stringWidth(this.aD);
            this.iD = 120;
            this.jD = (0 + i1 + 240);
            }
  
            void A(Graphics paramGraphics, bool parambool)
            {
            if (this.aD != null)
            {
                int i1 = yb.stringWidth(this.aD);
                paramGraphics.setColor(16777215);
                if ((i1 > 240) || (parambool))
                {
                if (this.iD <= 0 - i1 * 2) {
                    this.iD = 240;
                } else {
                    this.iD -= 3;
                }
                if (this.jD <= 0 - i1 - 120) {
                    this.jD = (i1 + 120);
                } else {
                    this.jD -= 3;
                }
                i1 = 0;
                parambool = false;
                }
                while (parambool < this.aD.length())
                {
                if ((this.iD + i1 > -15) && (this.iD + i1 < 255)) {
                    paramGraphics.drawString("" + this.aD.charAt(parambool), this.iD + i1, 215, 20);
                }
                if ((this.jD + i1 > -15) && (this.jD + i1 < 255)) {
                    paramGraphics.drawString("" + this.aD.charAt(parambool), this.jD + i1, 215, 20);
                }
                i1 += yb.charWidth(this.aD.charAt(parambool));
                parambool++;
                continue;
                paramGraphics.drawString(this.aD, (240 - i1) / 2, 215, 20);
                }
                paramGraphics.setColor(0);
            }
            }
  
            void A(int paramInt1, int[] paramArrayOfInt1, int[] paramArrayOfInt2, int paramInt2)
            {
            paramArrayOfInt1 = new int[10];
            paramArrayOfInt1[this.mD] = 12;
            paramArrayOfInt1[(this.mD + 1)] = paramInt2;
            paramArrayOfInt1[(this.mD + 2)] = 5;
            paramArrayOfInt1[(this.mD + 3)] = 106;
            paramArrayOfInt1[(this.mD + 4)] = 6;
            paramArrayOfInt1[(this.mD + 5)] = 107;
            paramArrayOfInt1[(this.mD + 6)] = 13;
            paramArrayOfInt1[(this.mD + 7)] = 178;
            paramArrayOfInt1[(this.mD + 8)] = 10;
            paramArrayOfInt1[(this.mD + 9)] = 111;
            paramArrayOfInt2 = new int[6];
            paramArrayOfInt2[0] = ja[paramInt1];
            paramArrayOfInt2[2] = paramInt1;
            paramArrayOfInt2[5] = IA(-1);
            paramArrayOfInt2[3] = ja[paramArrayOfInt2[5]];
            paramInt1 = I(paramArrayOfInt2[2], paramArrayOfInt2[5]);
            paramArrayOfInt2[1] = paramInt1[0];
            paramArrayOfInt2[4] = paramInt1[1];
            this.yD = paramArrayOfInt2;
            this.kD = D(100);
            A(7, paramArrayOfInt1, -1, paramArrayOfInt2, D(83));
            }
  
            int IA(int paramInt)
            {
    
            if (paramInt == 14) {
                paramInt = 0;
            }
            while ((paramInt == 2) || (paramInt == 9) || (paramInt == 11) || (paramInt == 13) || (this.cc.h[paramInt] == 0))
            {
                paramInt++;
                if (paramInt == 14) {
                paramInt = 0;
                }
            }
            return paramInt;
            }
  
            int[] I(int paramInt1, int paramInt2)
            {
            int[] arrayOfInt = new int[2];
            int i1 = this.qB;
            if (i1 > 74) {
                i1 = 74;
            } else if (i1 < 27) {
                i1 = 27;
            }
            int i2 = ia[1][this.ed[this.jd][this.id].c][paramInt2];
            paramInt2 = 1;
            if (paramInt1 != 9) {
                paramInt2 = ia[0][this.ed[this.jd][this.id].c][paramInt1];
            }
            this = i2 * i1 / 5;
            paramInt1 = paramInt2 * (100 - i1) / 5;
            if (this % 10 >= 5) {
                this = this / 10 + 1;
            } else {
                this /= 10;
            }
            if (paramInt1 % 10 >= 5) {
                paramInt1 = paramInt1 / 10 + 1;
            } else {
                paramInt1 /= 10;
            }
            if ((this == 0) || (paramInt1 == 0))
            {
                this++;
                paramInt1++;
            }
            while (((this % 2 == 0) && (paramInt1 % 2 == 0)) || ((this % 3 == 0) && (paramInt1 % 3 == 0)) || ((this % 5 == 0) && (paramInt1 % 5 == 0)) || ((this % 7 == 0) && (paramInt1 % 7 == 0)))
            {
                if ((this % 2 == 0) && (paramInt1 % 2 == 0))
                {
                this /= 2;
                paramInt1 /= 2;
                }
                if ((this % 3 == 0) && (paramInt1 % 3 == 0))
                {
                this /= 3;
                paramInt1 /= 3;
                }
                if ((this % 5 == 0) && (paramInt1 % 5 == 0))
                {
                this /= 5;
                paramInt1 /= 5;
                }
                if ((this % 7 == 0) && (paramInt1 % 7 == 0))
                {
                this /= 7;
                paramInt1 /= 7;
                }
            }
            arrayOfInt[0] = this;
            arrayOfInt[1] = paramInt1;
            return arrayOfInt;
            }
  
            void A(int[] paramArrayOfInt1, int[] paramArrayOfInt2)
            {
            if (paramArrayOfInt2[2] == 2) {
                paramArrayOfInt1 = 157;
            } else if (paramArrayOfInt2[2] == 9) {
                paramArrayOfInt1 = 164;
            } else {
                paramArrayOfInt1 = 167;
            }
            int[] arrayOfInt2 = new int[10];
            arrayOfInt2[this.mD] = 12;
            arrayOfInt2[(this.mD + 1)] = paramArrayOfInt1;
            arrayOfInt2[(this.mD + 2)] = 5;
            arrayOfInt2[(this.mD + 3)] = 106;
            arrayOfInt2[(this.mD + 4)] = 6;
            arrayOfInt2[(this.mD + 5)] = 107;
            arrayOfInt2[(this.mD + 6)] = 13;
            arrayOfInt2[(this.mD + 7)] = 150;
            arrayOfInt2[(this.mD + 8)] = 10;
            arrayOfInt2[(this.mD + 9)] = 111;
            int[] arrayOfInt1 = new int[10];
            arrayOfInt1[0] = ja[paramArrayOfInt2[2]];
            arrayOfInt1[1] = this.cc.h[paramArrayOfInt2[2]];
            arrayOfInt1[2] = paramArrayOfInt2[2];
            arrayOfInt1[3] = paramArrayOfInt2[1];
            arrayOfInt1[4] = 0;
            arrayOfInt1[5] = ja[paramArrayOfInt2[5]];
            arrayOfInt1[6] = this.cc.h[paramArrayOfInt2[5]];
            arrayOfInt1[7] = paramArrayOfInt2[5];
            arrayOfInt1[8] = paramArrayOfInt2[4];
            arrayOfInt1[9] = 0;
            this.zD = arrayOfInt1;
            this.kD = D(100);
            for (paramArrayOfInt1 = 0; paramArrayOfInt1 < this.zd.length; paramArrayOfInt1++) {}
            if (paramArrayOfInt2[2] == 9) {
                A(12, arrayOfInt2, -1, arrayOfInt1, "");
            } else if (this.cc.h[paramArrayOfInt2[2]] == ba[(this.cc.a - 6)][paramArrayOfInt2[2]][this.cc.c]) {
                A(12, arrayOfInt2, -1, arrayOfInt1, D(115));
            } else if (this.cc.h[paramArrayOfInt2[2]] + paramArrayOfInt2[1] > ba[(this.cc.a - 6)][paramArrayOfInt2[2]][this.cc.c]) {
                A(12, arrayOfInt2, -1, arrayOfInt1, D(114));
            } else {
                A(12, arrayOfInt2, -1, arrayOfInt1, "");
            }
            }
  
            void B(int paramInt1, int[] paramArrayOfInt1, int[] paramArrayOfInt2, int paramInt2)
            {
            paramArrayOfInt1 = new int[10];
            paramArrayOfInt1[this.mD] = 12;
            paramArrayOfInt1[(this.mD + 1)] = paramInt2;
            paramArrayOfInt1[(this.mD + 2)] = 5;
            paramArrayOfInt1[(this.mD + 3)] = 106;
            paramArrayOfInt1[(this.mD + 4)] = 6;
            paramArrayOfInt1[(this.mD + 5)] = 107;
            paramArrayOfInt1[(this.mD + 6)] = 13;
            paramArrayOfInt1[(this.mD + 7)] = paramInt2;
            paramArrayOfInt1[(this.mD + 8)] = 10;
            paramArrayOfInt1[(this.mD + 9)] = 111;
            paramArrayOfInt2 = new int[3];
            paramArrayOfInt2[0] = ja[paramInt1];
            paramArrayOfInt2[1] = 0;
            paramArrayOfInt2[2] = paramInt1;
            this.wD = paramInt1;
            this.kD = D(104);
            A(7, paramArrayOfInt1, -1, paramArrayOfInt2, D(85));
            }
  
            void WB()
            {
            if (this.xD / 70 > 0)
            {
                if (this.qB + this.xD / 70 > 100) {
                this.qB = 100;
                } else {
                this.qB = ((byte)(this.qB + (short)(this.xD / 70)));
                }
                this.xD = ((short)(this.xD % 70));
            }
            XB();
            }
  
            public void N(Graphics paramGraphics)
            {
            if (this.aD == null) {
                return;
            }
            this.oD = C(this.aD);
            if (this.nD)
            {
                if (this.aD != null)
                {
                paramGraphics.setColor(16767412);
                this.gD -= 1;
                for (int i1 = this.hD; i1 <= this.gD + this.hD; i1++)
                {
                    String str = B(this.aD, i1);
                    if (str != null) {
                    paramGraphics.drawString(str, 30, 28 + (i1 - this.hD) * yb.getHeight(), 20);
                    }
                }
                this.gD += 1;
                paramGraphics.setColor(0);
                }
                this.nD = false;
            }
            }
  
            public static String B(String paramString, Font paramFont, int paramInt)
            {
            String str = "";
            int i4 = 0;
            int i3 = 0;
            int i2 = -1;
            int i1 = 0;
            while (i4 < paramString.length())
            {
                char c1 = paramString.charAt(i4);
                if (c1 == '\n')
                {
                str = str + paramString.substring(i1, i4);
                i1 = i4;
                i3 = 0;
                if (i4 == paramString.length() - 1) {
                    str = str + "\n";
                }
                }
                else
                {
                i3 += paramFont.charWidth(c1);
                if (i3 >= paramInt)
                {
                    if (i2 != -1)
                    {
                    if (i1 == i2)
                    {
                        str = str + paramString.substring(i1, i4);
                        i1 = i2 = i4;
                    }
                    else
                    {
                        if (i2 < i1) {
                        str = str + paramString.substring(i2, i1);
                        } else {
                        str = str + paramString.substring(i1, i2);
                        }
                        i2++;
                        i1 = i2;
                        i4 = i2;
                    }
                    i3 = paramFont.charWidth(paramString.charAt(i4));
                    }
                    else
                    {
                    str = str + paramString.substring(i1, i4);
                    i1 = i4;
                    i3 = 0;
                    }
                    str = str + "\n";
                }
                }
                if (c1 == ' ') {
                i2 = i4;
                }
                i4++;
            }
            return str;
            }
  
            int C(String paramString)
            {
            int i1 = 0;
            for (this = 0; this < paramString.length(); this++) {
                if (paramString.charAt(this) == '\n') {
                i1++;
                }
            }
            return i1;
            }
  
            String B(String paramString, int paramInt)
            {
            String str = "";
            int i1 = 0;
            for (this = 0; this < paramString.length(); this++)
            {
                if (i1 == paramInt) {
                str = str + paramString.charAt(this);
                }
                if (paramString.charAt(this) == '\n') {
                i1++;
                }
            }
            if (str.equals("")) {
                return null;
            }
            return str.trim();
            }
  
            void A(A paramA, int paramInt, short paramShort)
            {
            paramA.a = ((byte)paramInt);
            if ((paramA.a >= 0) && (paramA.a < 6)) {
                paramA.b = ((byte)G(0, 3));
            }
            for (int i1 = 0; i1 < 3; i1++) {
                paramA.f[i1] = ((short)G(aa[paramInt][1] - aa[paramInt][1] / 3 + 1, aa[paramInt][1]));
            }
            for (paramInt = 0; paramInt < 3; paramInt++) {
                paramA.g[paramInt] = paramA.f[paramInt];
            }
            paramA.i = paramShort;
            A(paramA.i, 4, paramA.t, paramA.u, 0, -24, 48, 36, 0, 10, 0, 2);
            paramInt = paramA.o.size();
            for (;;)
            {
                paramInt--;
                if (paramInt < 0) {
                break;
                }
                this = (D)paramA.o.elementAt(paramInt);
                if (this.d == 3) {
                H();
                }
            }
            }
  
            void G(A paramA)
            {
            paramA.i = ((short)(ca[(paramA.a - 6)][(paramA.c + 1)] * 100));
            paramA.d = ((byte)(paramA.c + 2));
            A(paramA.i, 8, paramA.t, paramA.u, 0, -24, 48, 36, 0, 6, 0, 2);
            if ((paramA.a != 11) && (paramA.a != 12)) {
                N(22);
            }
            }
  
            void A(A paramA, int paramInt)
            {
            for (int i1 = 0; i1 < 14; i1++) {
                this.cc.h[i1] -= ea[(paramInt - 6)][0][i1];
            }
            paramA.a = ((byte)paramInt);
            paramA.c = 0;
            paramA.d = 1;
            for (i1 = 0; i1 < 3; i1++) {
                paramA.f[i1] = 0;
            }
            paramA.j = 0;
            if ((fe[paramA.a][1] > -1) || (paramA.a == 14) || (paramA.a == 11)) {
                paramA.e = 0;
            } else {
                paramA.e = -1;
            }
            paramA.i = ((short)(ca[(paramA.a - 6)][paramA.c] * 100));
            for (i1 = 0; i1 < 14; i1++) {
                paramA.h[i1] = 0;
            }
            A(paramA);
            if (paramInt == 15)
            {
                paramInt = A(paramA.t, paramA.u, 0, -1, false);
                if (paramInt != null) {
                A(paramInt, 4, paramA.i);
                }
            }
            A(paramA.i, 8, paramA.t, paramA.u, 0, -24, 48, 36, 0, 8, 0, 2);
            if ((paramA.a != 11) && (paramA.a != 12)) {
                N(22);
            }
            }
  
            void A(A paramA, bool parambool)
            {
            if ((paramA.a != 11) && (paramA.a != 12)) {
                N(22);
            }
            if (paramA.c == 0)
            {
                if (paramA.a == 13)
                {
                this.fc = 1;
                K(207);
                return;
                }
                paramA.i = ((short)(z[0] * 100));
                paramA.a = 0;
                paramA.c = 0;
                paramA.d = 0;
                for (int i1 = 0; i1 < 3; i1++)
                {
                paramA.f[i1] = 0;
                paramA.g[i1] = 0;
                }
                for (i1 = 0; i1 < 14; i1++) {
                paramA.h[i1] = 0;
                }
                paramA.j = 0;
                paramA.m = 0;
                paramA.n = 0;
                paramA.e = 0;
                if (paramA.p != null)
                {
                paramA.p.A(true);
                paramA.p = null;
                }
                if (paramA.q != null)
                {
                paramA.q.A(true);
                paramA.q = null;
                }
                if (this.rd != null) {
                for (int i3 = 0; i3 < this.rd.size(); i3++)
                {
                    D localD = (D)this.rd.elementAt(i3);
                    if (localD.e == paramA)
                    {
                    localD.A(true);
                    this.rd.removeElementAt(i3);
                    }
                }
                }
            }
            else
            {
                paramA.i = ((short)(da[(paramA.a - 6)][paramA.c] * 100));
                A tmp277_276 = paramA;
                tmp277_276.c = ((byte)(tmp277_276.c - 1));
                for (int i2 = 0; i2 < 14; i2++) {
                if ((i2 != 9) && (paramA.a != 10) && (paramA.h[i2] > ba[(paramA.a - 6)][i2][paramA.c])) {
                    paramA.h[i2] = ba[(paramA.a - 6)][i2][paramA.c];
                } else if ((i2 == 9) && (paramA.a == 10) && (paramA.h[i2] > ba[(paramA.a - 6)][i2][paramA.c])) {
                    paramA.h[i2] = ba[(paramA.a - 6)][i2][paramA.c];
                }
                }
                if (paramA.e == -1) {
                paramA.j = 0;
                } else {
                paramA.j = 20;
                }
                A tmp459_458 = paramA;
                tmp459_458.m = ((short)(tmp459_458.m + paramA.j * (1000 - paramA.n - paramA.k) * 100 / 1000));
                paramA.n = ((short)(1000 - paramA.k));
            }
            if (parambool) {
                A(paramA.i, 8, paramA.t, paramA.u, 0, -24, 48, 36, 0, 6, 0, 2);
            }
            }
  
            void XB()
            {
            if ((this.vB == 1) && (this.qB >= 60)) {
                this.vB = 0;
            } else if ((this.vB == 0) && (this.qB <= 20)) {
                this.vB = 1;
            }
            }
  
            private void YB()
            {
            int i5 = G(0, 100) > 50 ? 1 : 0;
            A localA = null;
            this.oB = null;
            this.pB = null;
            int i4;
            if (i5 != 0) {
                i4 = G(4, 7);
            } else {
                i4 = G(1, 3);
            }
            int i2;
            int i1;
            switch (i4)
            {
            case 1: 
            case 4: 
                localA = null;
                int i3 = (byte)G(0, 13);
                if (i5 != 0)
                {
                i2 = 50 < this.cc.h[i3] ? 50 : this.cc.h[i3];
                i1 = 48;
                }
                else
                {
                i2 = 50 < ba[7][i3][this.cc.c] - this.cc.h[i3] ? 50 : ba[7][i3][this.cc.c] - this.cc.h[i3];
                i1 = 46;
                }
                if (i2 > 0)
                {
                i2 = G(1, i2) * (i5 != 0 ? -1 : 1);
                this.cc.h[i3] += i2;
                this.oB = (D(i1) + "\n" + D(158) + "\n" + D(ya[i3]) + " " + i2);
                }
                else
                {
                i4 = 0;
                this.oB = null;
                }
                break;
            case 2: 
                localA = F(1, -1);
                if (localA != null)
                {
                G(localA);
                this.oB = (D(54) + "\n" + D(za[localA.a]));
                }
                else
                {
                i4 = 0;
                this.oB = null;
                }
                break;
            case 5: 
                localA = F(2, -1);
                if (localA != null)
                {
                if (localA.c == 0)
                {
                    i2 = localA.a;
                    this.oB = (D(39) + "\n" + D(za[i2]));
                }
                else
                {
                    i2 = localA.a;
                    this.oB = (D(38) + "\n" + D(za[i2]));
                }
                A(localA, true);
                }
                else
                {
                i4 = 0;
                this.oB = null;
                }
                break;
            case 3: 
                localA = B(ua);
                if (localA != null)
                {
                i2 = localA.a;
                i1 = ta[G(0, ta.length - 1)];
                A(localA, i1, (short)(z[i1] * 100));
                this.oB = (D(44) + "\n" + D(za[i2]) + " -> " + D(za[i1]));
                }
                else
                {
                i4 = 0;
                this.oB = null;
                }
                break;
            case 6: 
                localA = B(ta);
                if (localA != null)
                {
                i2 = localA.a;
                A(localA, 0, (short)(z[0] * 100));
                this.oB = (D(44) + "\n" + D(za[i2]) + " -> " + D(za[0]));
                }
                else
                {
                i4 = 0;
                this.oB = null;
                }
                break;
            case 7: 
                localA = F(2, 0);
                if (localA != null)
                {
                A tmp771_769 = localA;
                tmp771_769.m = ((short)(tmp771_769.m + localA.j * (1000 - localA.n - localA.k) * 100 / 1000));
                localA.j = 0;
                localA.e = -1;
                localA.n = ((short)(1000 - localA.k));
                this.oB = (D(47) + "\n" + D(za[localA.a]));
                }
                else
                {
                i4 = 0;
                this.oB = null;
                }
                break;
            }
            this.pB = localA;
            if (this.oB != null)
            {
                this.oB = (D(31) + " " + (this.fB + 1) + ":\n" + this.oB);
                if ((i4 >= 1) && (i4 <= 3)) {
                N(5);
                } else {
                N(6);
                }
                H(0, -1);
                this.yc = true;
            }
            }
  
            private void H(A paramA)
            {
            this.ce[0][0] = 8;
            this.ce[0][1] = '?';
            this.ce[0][2] = this.fB;
            this.ce[0][7] = 45;
            this.de[0] = paramA;
            }
  
            private void JA(int paramInt)
            {
            if (paramInt == -1)
            {
                paramInt = this.qB;
                if (paramInt < 40) {
                paramInt = 40;
                }
                if (paramInt > 50)
                {
                if (G(0, (paramInt - 40) / 10) != 0) {
                    this.hB = true;
                }
                }
                else if (G(0, (60 - paramInt) / 10) == 0) {
                this.hB = true;
                }
                if (this.hB)
                {
                this.oB = D(50);
                this.iB = ((byte)G(3, 5) * 100);
                this.oB += " ";
                this.oB += this.iB / 100;
                this.pB = this.cc;
                }
                else
                {
                paramInt = G(1, 3);
                if (paramInt == 1) {
                    this.oB = D(51);
                } else if (paramInt == 2) {
                    this.oB = D(52);
                } else {
                    this.oB = D(53);
                }
                this.iB = -1;
                this.pB = null;
                }
            }
            else
            {
                this.hB = true;
                this.oB = D(50);
                this.iB = paramInt;
                this.oB += " ";
                this.oB += this.iB / 100;
                this.pB = this.cc;
            }
            this.vD = QB();
            N(21);
            H(0, -1);
            this.yc = true;
            }
  
            public void J(int paramInt1, int paramInt2)
            {
            this.ce[1][0] = 9;
            this.ce[1][1] = '?';
            this.ce[1][2] = this.fB;
            this.ce[1][3] = ((byte)paramInt1);
            this.ce[1][4] = paramInt2;
            this.ce[1][7] = 40;
            this.de[1] = this.cc;
            }
  
            private void ZB()
            {
            for (this.be = 0; (this.be < va.length - 1) && (this.fB >= va[this.be]); this.be = ((byte)(this.be + 1))) {}
            this.ae = ((short)(xa[this.be] * 100));
            }
  
            private void AC()
            {
            int i1 = 3;
            for (;;)
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                if (this.ce[i1][1] > 0) {
                this.ce[i1][1] -= 1;
                }
            }
            if (this.ae > 0)
            {
                this.ae = ((short)(this.ae - 1));
            }
            else
            {
                if ((G(0, 100) < wa[this.be]) && (!this.nB)) {
                YB();
                }
                ZB();
            }
            }
  
            public void BC()
            {
            this.ae = 0;
            this.be = 0;
            int i1 = 3;
            for (;;)
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                this.ce[i1][0] = 0;
                this.ce[i1][1] = 0;
            }
            i1 = 8;
            for (;;)
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                this.de[i1] = null;
            }
            }
  
            public void CC()
            {
            this.eB += 1;
            this.fB = (this.eB / 100);
            if ((this.jB == -1) && (this.eB >= this.kB))
            {
                if (this.eB % 1400 == 0)
                {
                if (!this.gB) {
                    JA(-1);
                }
                }
                else if (this.eB % 1400 == this.iB) {
                this.hB = false;
                }
            }
            else if ((this.jB <= this.eB) && (this.jB != -1) && (!this.hB))
            {
                JA(this.iB);
            }
            else if (this.eB - this.jB == this.iB)
            {
                this.hB = false;
                this.jB = -1;
                this.kB = (this.eB + 1400);
            }
            int i3 = this.wC;
            i3--;
            if (i3 >= 0)
            {
                int i2 = this.vC;
                for (;;)
                {
                i2--;
                if (i2 < 0) {
                    break;
                }
                A localA = this.ed[i3][i2];
                if (localA.i == 0)
                {
                    if ((localA.a >= 6) && (localA.a != 14) && ((localA.a != 10) || (!localA.x)) && (localA.a != 11) && (localA.a != 12))
                    {
                    I(localA);
                    L(localA);
                    }
                }
                else
                {
                    A tmp279_278 = localA;
                    tmp279_278.i = ((short)(tmp279_278.i - 1));
                    if ((localA.i == 0) && (localA.d > 0))
                    {
                    localA.c = ((byte)(localA.d - 1));
                    if (localA.e == -1)
                    {
                        localA.m = 0;
                        localA.j = 0;
                        localA.n = 0;
                    }
                    else if (J(localA))
                    {
                        A tmp349_348 = localA;
                        tmp349_348.m = ((short)(tmp349_348.m + localA.j * (1000 - localA.n - localA.k) * 100 / 1000));
                        localA.j = w[localA.c];
                        localA.n = ((short)(1000 - localA.k));
                    }
                    localA.d = 0;
                    }
                }
                int i1 = localA.o.size();
                for (;;)
                {
                    i1--;
                    if (i1 < 0) {
                    break;
                    }
                    D localD = (D)localA.o.elementAt(i1);
                    localD.C();
                }
                }
            }
            }
  
            public void I(A paramA)
            {
            if (paramA.w) {
                return;
            }
            if (paramA.k > 0)
            {
                A tmp16_15 = paramA;
                tmp16_15.k = ((short)(tmp16_15.k - 1));
            }
            else
            {
                A tmp30_29 = paramA;
                tmp30_29.m = ((short)(tmp30_29.m + paramA.j * (1000 - paramA.n - paramA.k) * 100 / 1000));
                if (J(paramA))
                {
                K(paramA);
                }
                else
                {
                K(paramA);
                H(paramA);
                paramA.j = 0;
                paramA.e = -1;
                }
                paramA.k = 1000;
                paramA.m = 0;
                paramA.n = 0;
            }
            }
  
            public bool J(A paramA)
            {
            int i2 = 14;
            do
            {
                i2--;
                if (i2 < 0) {
                break;
                }
                i1 = (fa[(paramA.a - 6)][paramA.c][i2] * paramA.m + 1000) / 2000;
            } while (this.cc.h[i2] >= i1);
            return false;
            int i1 = fa[(paramA.a - 6)][paramA.c][14];
            if (i1 >= 0)
            {
                paramA = (fa[(paramA.a - 6)][paramA.c][15] * paramA.m + 1000) / 2000;
                this = this.cc.h[objectFieldByteMatrix[i1][0]] + this.cc.h[objectFieldByteMatrix[i1][1]] + this.cc.h[objectFieldByteMatrix[i1][2]];
                if (this < paramA) {
                return false;
                }
            }
            return true;
            }
  
            public void K(A paramA)
            {
            int i2 = 14;
            for (;;)
            {
                i2--;
                if (i2 < 0) {
                break;
                }
                i1 = (fa[(paramA.a - 6)][paramA.c][i2] * paramA.m + 1000) / 2000;
                this.cc.h[i2] -= i1;
                if (this.cc.h[i2] < 0) {
                this.cc.h[i2] = 0;
                }
            }
            int i1 = fa[(paramA.a - 6)][paramA.c][14];
            if (i1 >= 0)
            {
                i2 = (fa[(paramA.a - 6)][paramA.c][15] * paramA.m + 1000) / 2000;
                while (i2 > 0)
                {
                paramA = G(0, 2);
                if (this.cc.h[objectFieldByteMatrix[i1][paramA]] > 0)
                {
                    this.cc.h[objectFieldByteMatrix[i1][paramA]] -= 1;
                    i2--;
                }
                if (this.cc.h[objectFieldByteMatrix[i1][0]] + this.cc.h[objectFieldByteMatrix[i1][1]] + this.cc.h[objectFieldByteMatrix[i1][2]] == 0) {
                    i2 = 0;
                }
                }
            }
            }
  
            public void L(A paramA)
            {
            if ((paramA.e == -1) || (paramA.w) || (ha[(paramA.a - 6)][(paramA.c * 3 + paramA.e)][14] == -1)) {
                return;
            }
            if ((paramA.a == 6) && (paramA.e == 1))
            {
                if (paramA.l > 0)
                {
                A tmp71_70 = paramA;
                tmp71_70.l = ((short)(tmp71_70.l - 1));
                }
                else if (M(paramA))
                {
                N(paramA);
                O(paramA);
                paramA.l = ((short)(ga[(paramA.a - 6)][paramA.e] * 100));
                }
                return;
            }
            if ((paramA.a == 10) && (paramA.h[ha[(paramA.a - 6)][(paramA.c * 3 + paramA.e)][14]] == ba[(paramA.a - 6)][ha[(paramA.a - 6)][(paramA.c * 3 + paramA.e)][14]][paramA.c])) {
                return;
            }
            switch (paramA.a)
            {
            case 6: 
            case 7: 
            case 13: 
            case 15: 
                if ((paramA.p != null) && (paramA.p.d == 1) && (M(paramA)))
                {
                if (paramA.p.G()) {
                    N(paramA);
                }
                paramA.l = ((short)(ga[(paramA.a - 6)][paramA.e] * 100));
                }
                break;
            case 8: 
            case 9: 
            case 10: 
            case 14: 
                if (paramA.l > 0)
                {
                A tmp348_347 = paramA;
                tmp348_347.l = ((short)(tmp348_347.l - 1));
                }
                else if (M(paramA))
                {
                N(paramA);
                O(paramA);
                paramA.l = ((short)(ga[(paramA.a - 6)][paramA.e] * 100));
                }
                break;
            }
            }
  
            public bool M(A paramA)
            {
            int i1 = 14;
            if (paramA.e == -1) {
                return false;
            }
            do
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                this = ha[(paramA.a - 6)][(paramA.c * 3 + paramA.e)][i1] * 5 * paramA.j / 100;
            } while (paramA.h[i1] >= this);
            return false;
            return true;
            }
  
            public void N(A paramA)
            {
            int i1 = 14;
            for (;;)
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                this = ha[(paramA.a - 6)][(paramA.c * 3 + paramA.e)][i1] * 5 * paramA.j / 100;
                paramA.h[i1] -= this;
                if (paramA.h[i1] < 0) {
                paramA.h[i1] = 0;
                }
            }
            }
  
            public void O(A paramA)
            {
            int i2 = ha[(paramA.a - 6)][(paramA.c * 3 + paramA.e)][14];
            if (i2 != -1)
            {
                int i1 = ha[(paramA.a - 6)][(paramA.c * 3 + paramA.e)][15] * 5 * paramA.j / 100;
                paramA.h[i2] += i1 + KA(i2);
                this = (short)ba[(paramA.a - 6)][i2][paramA.c];
                if (paramA.h[i2] > this) {
                paramA.h[i2] = this;
                }
            }
            }
  
            public int KA(int paramInt)
            {
            Vector localVector = A(12, false, -1);
            int i1 = localVector.size();
            do
            {
                i1--;
                if (i1 < 0) {
                break;
                }
                this = (A)localVector.elementAt(i1);
            } while (this.e != paramInt);
            return ha[(this.hugeArrayWithNumbers - 6)][(this.c * 3 + 0)][15];
            return 0;
            }
  
            private int[] P(A paramA)
            {
            paramA = this.vC - 1;
            int i1 = this.wC - 1;
            this = new int[2];
            this[0] = paramA;
            this[1] = i1;
            return this;
            }
  
            public D[] A(Vector paramVector, A paramA)
            {
            if (paramVector != null) {
                for (int i1 = 0; i1 < paramVector.size(); i1++)
                {
                this = (D[])paramVector.elementAt(i1);
                if (this[0].e == paramA) {
                    return this;
                }
                }
            }
            return null;
            }
  
            public void A(Vector paramVector, A paramA, int paramInt1, int paramInt2)
            {
            D[] arrayOfD = A(paramVector, paramA);
            if (arrayOfD != null)
            {
                paramA = G(3, 6) * 100;
                for (paramVector = 0; paramVector < arrayOfD.length; paramVector++)
                {
                if (paramInt1 < 0) {
                    arrayOfD[paramVector].y = (paramVector * 5 + paramA);
                } else {
                    arrayOfD[paramVector].y = paramInt1;
                }
                arrayOfD[paramVector].x = ((short)paramInt2);
                arrayOfD[paramVector].H();
                arrayOfD[paramVector].w = ((byte)arrayOfD.length);
                if ((paramVector >= this.le) && (paramInt2 == 2) && (paramInt1 < 0)) {
                    arrayOfD[paramVector].x = 5;
                }
                }
            }
            }
  
        private int LA(int paramInt)
        {
            if (paramInt == 0) {
                return 1;
            }
            if (paramInt == 1) {
                return 3;
            }
            if (paramInt == 2) {
                return 5;
            }
            return 10;
        }
  
            public void A(bool parambool, A paramA)
            {
            if ((B(this.ke, paramA) < 0) && (Q(paramA)))
            {
                int i4 = LA(paramA.c);
                if (i4 > 0)
                {
                int[] arrayOfInt = P(paramA);
                int i3 = arrayOfInt[0];
                int i2 = arrayOfInt[1];
                D[] arrayOfD = new D[i4];
                for (int i1 = 0; i1 < i4; i1++) {
                    if (i1 == i4 - 1)
                    {
                    if (parambool) {
                        arrayOfD[i1] = new D(this, 3 + i4 - 1, paramA, this.ed[i2][i3]);
                    } else {
                        arrayOfD[i1] = new D(this, 11 + i4 - 1, paramA, this.ed[i2][i3]);
                    }
                    arrayOfD[i1].v = ((byte)D(paramA));
                    arrayOfD[i1].x = 0;
                    arrayOfD[i1].y = (i1 * 5);
                    }
                    else
                    {
                    if (parambool) {
                        arrayOfD[i1] = new D(this, 2, paramA, this.ed[i2][i3]);
                    } else {
                        arrayOfD[i1] = new D(this, 16, paramA, this.ed[i2][i3]);
                    }
                    arrayOfD[i1].v = ((byte)D(paramA));
                    arrayOfD[i1].y = (i1 * 5);
                    arrayOfD[i1].x = 0;
                    }
                }
                this.ke.addElement(arrayOfD);
                N(26);
                }
            }
            }
  
            public int B(Vector paramVector, A paramA)
            {
            if (paramVector != null) {
                for (int i1 = 0; i1 < paramVector.size(); i1++)
                {
                this = (D[])paramVector.elementAt(i1);
                if (this[0].e == paramA) {
                    return i1;
                }
                }
            }
            return -1;
            }
  
            public int A(Vector paramVector)
            {
            if (paramVector != null) {
                for (int i1 = 0; i1 < paramVector.size(); i1++)
                {
                D[] arrayOfD = (D[])paramVector.elementAt(i1);
                for (this = 0; this < arrayOfD.length; this++) {
                    if (arrayOfD[this].aa) {
                    return i1;
                    }
                }
                }
            }
            return -1;
            }
  
            public void C(Vector paramVector, A paramA)
            {
            if (paramVector != null) {
                for (int i1 = 0; i1 < paramVector.size(); i1++)
                {
                this = (D[])paramVector.elementAt(i1);
                if (this[0].e == paramA)
                {
                    for (paramA = 0; paramA < this.length; paramA++) {
                    this[paramA].d = 5;
                    }
                    paramVector.removeElementAt(i1);
                    return;
                }
                }
            }
            }
  
            private bool Q(A paramA)
            {
            paramA.m = ((short)(paramA.j * 100));
            if (J(paramA)) {
                K(paramA);
            } else {
                return false;
            }
            return true;
            }
  
            static int A(Townsmen3 paramTownsmen3)
            {
            return paramTownsmen3.m;
            }
  
            static bool A(Townsmen3 paramTownsmen3, bool parambool)
            {
            return paramTownsmen3.l = parambool;
            }
  
            static int A(Townsmen3 paramTownsmen3, int paramInt)
            {
            return paramTownsmen3.m = paramInt;
            }

    }
}