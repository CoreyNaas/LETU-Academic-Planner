using System;
using System.Windows.Forms;

namespace claendermockup
{
    internal class CatalogLoad
    {
        public static TreeNode Load()
        {

            //TreeNode node2 = new TreeNode("DON'T DO IT");
            //TreeNode node3 = new TreeNode("UNLESS YOUR HATE YOURSELF");
            //TreeNode[] array = new TreeNode[] { node2, node3 };
            //TreeNode BSMENode = new TreeNode("Engineering, Mechanical", array);

            //TreeNode cosc_cst = new TreeNode("COSC");
            //TreeNode eetc_cst = new TreeNode("EETC");
            //TreeNode[] CST = new TreeNode[] { cosc_cst, eetc_cst };
            //TreeNode CSTNode = new TreeNode("Computer Science & Engineering Technology", CST);

            TreeNode cosc_1303 = new TreeNode("COSC 1303");
            cosc_1303.Tag = "hello";
            TreeNode cosc_2103 = new TreeNode("");
            TreeNode cosc_2203 = new TreeNode("COSC 2203");
            TreeNode cosc_3303 = new TreeNode("COSC 3303");
            TreeNode cosc_3403 = new TreeNode("COSC 3403");
            TreeNode cosc_3503 = new TreeNode("COSC 3403");
            TreeNode cosc_3603 = new TreeNode("COSC 3603");
            TreeNode cosc_4503 = new TreeNode("COSC 4503");
            TreeNode cosc_elec = new TreeNode("COSC Jr/Sr Elective");
            TreeNode[] COSC = new TreeNode[] { cosc_1303, cosc_2103, cosc_2203, cosc_3303, cosc_3403, cosc_3503, cosc_3603, cosc_4503, cosc_elec };
            TreeNode COSC1 = new TreeNode("Computer Science & Engineering Technology", COSC);

            TreeNode eetc_1021 = new TreeNode("EETC 1021");
            TreeNode eetc_1022 = new TreeNode("EETC 1022");
            TreeNode eetc_1041 = new TreeNode("EETC 1041");
            TreeNode eetc_1042 = new TreeNode("EETC 1042");
            TreeNode eetc_2313 = new TreeNode("EETC 2313");
            TreeNode eetc_2324 = new TreeNode("EETC 2324");
            TreeNode eetc_3213 = new TreeNode("EETC 3213");
            TreeNode eetc_4213 = new TreeNode("EETC 4213");
            TreeNode eetc_4313 = new TreeNode("EETC 4313");
            TreeNode[] EETC = new TreeNode[] { eetc_1021, eetc_1022, eetc_1041, eetc_1042, eetc_2313, eetc_2324, eetc_3213, eetc_4213, eetc_4313 };

            //TreeNode CSTNode[] = new TreeNode[] {COSC, EETC };

            return COSC1;
        }
    }
}