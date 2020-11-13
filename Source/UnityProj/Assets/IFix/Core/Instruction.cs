/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Initblk,
        Ldind_U4,
        Stelem_Any,
        Sizeof,
        Ldelem_R4,
        Stind_I1,
        Add_Ovf_Un,
        Stelem_Ref,
        Ldind_I2,
        Ldind_I4,
        Ldobj,
        Ldelem_I4,
        Constrained,
        Ldc_I4,
        Refanytype,
        Add_Ovf,
        Ldelem_I,
        Rethrow,
        Ldstr,
        Starg,
        Unbox_Any,
        Ldtype, // custom
        Break,
        Conv_Ovf_U4,
        Castclass,
        Stloc,
        Div_Un,
        Newarr,
        Ldtoken,
        Callvirt,
        Arglist,
        Conv_Ovf_I1_Un,
        Endfilter,
        Stind_R4,
        Conv_I1,
        No,
        Stfld,
        Ldfld,
        Shr,
        Stind_I,
        Conv_R8,
        Ldflda,
        Conv_I,

        //Pseudo instruction
        StackSpace,
        Tail,
        Conv_R_Un,
        Ble,
        Xor,
        Conv_Ovf_U4_Un,
        Initobj,
        Mkrefany,
        Ldnull,
        Ldelem_U2,
        Bgt,
        And,
        Ldind_R8,
        Ldind_Ref,
        Ldind_I1,
        Conv_U8,
        Callvirtvirt,
        Stind_I4,
        Ldftn,
        Dup,
        Add,
        Bge,
        Stelem_I,
        Newobj,
        Conv_Ovf_I_Un,
        Unaligned,
        Mul,
        Shl,
        Conv_Ovf_I8_Un,
        Ldind_U1,
        Call,
        Or,
        Conv_Ovf_U2_Un,
        Bne_Un,
        Readonly,
        Ldc_R4,
        Stind_R8,
        Ldvirtftn,
        Conv_Ovf_U8,
        Box,
        Ldarga,
        Endfinally,
        Ldind_I,
        Ldelem_I1,
        Ceq,
        Conv_Ovf_U_Un,
        Conv_Ovf_I,
        Nop,
        Conv_U,
        Ldlen,
        Stind_Ref,
        Conv_Ovf_I4_Un,
        Leave,
        Stelem_R8,
        Conv_I4,
        Stelem_I1,
        Brfalse,
        Ckfinite,
        Beq,
        Div,
        Ldc_R8,
        Ldelem_I8,
        Mul_Ovf_Un,
        Conv_I2,
        Ldind_I8,
        Blt_Un,
        Conv_U4,
        Rem_Un,
        Ldsfld,
        Volatile,
        Conv_Ovf_U1,
        Ldelem_I2,
        Stind_I2,
        Brtrue,
        Sub_Ovf,
        Neg,
        Conv_I8,
        Br,
        Sub,
        Ldloca,
        Ldelem_U1,
        Ldelem_U4,
        Rem,
        Conv_Ovf_U1_Un,
        CallExtern,
        Cpobj,
        Jmp,
        Stelem_R4,
        Ldelem_Ref,
        Conv_U1,
        Pop,
        Ble_Un,
        Cpblk,
        Ldind_R4,
        Stelem_I8,
        Cgt,
        Ret,
        Ldc_I8,
        Conv_Ovf_U,
        Ldind_U2,
        Bge_Un,
        Ldsflda,
        Conv_Ovf_U2,
        Cgt_Un,
        Ldvirtftn2,
        Stobj,
        Switch,
        Stelem_I4,
        Isinst,
        Conv_Ovf_I2_Un,
        Refanyval,
        Stind_I8,
        Not,
        Conv_Ovf_I8,
        Conv_Ovf_I4,
        Ldloc,
        Conv_R4,
        Clt,
        Ldelem_R8,
        Mul_Ovf,
        Stsfld,
        Conv_U2,
        Blt,
        Stelem_I2,
        Ldelem_Any,
        //Calli,
        Conv_Ovf_U8_Un,
        Ldelema,
        Ldarg,
        Shr_Un,
        Bgt_Un,
        Unbox,
        Throw,
        Sub_Ovf_Un,
        Newanon,
        Conv_Ovf_I2,
        Localloc,
        Clt_Un,
        Conv_Ovf_I1,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 鎸囦护MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 7051175246885954970;

        /// <summary>
        /// 褰撳墠鎸囦护
        /// </summary>
        public Code Code;

        /// <summary>
        /// 鎿嶄綔鏁?
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}