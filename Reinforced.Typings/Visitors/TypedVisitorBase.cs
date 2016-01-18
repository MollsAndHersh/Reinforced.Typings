﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reinforced.Typings.Ast;

namespace Reinforced.Typings.Visitors
{
    abstract class TypedVisitorBase<T> : IRtVisitor<T>
    {
        public T Visit(RtNode node)
        {
            if (node is RtField) return Visit((RtField)node);
            if (node is RtInterface) return Visit((RtInterface)node);
            if (node is RtFuncion) return Visit((RtFuncion)node);
            if (node is RtArgument) return Visit((RtArgument)node);
            if (node is RtClass) return Visit((RtClass)node);
            if (node is RtIdentifier) return Visit((RtIdentifier)node);
            if (node is RtDelegateType) return Visit((RtDelegateType)node);
            if (node is RtSimpleTypeName) return Visit((RtSimpleTypeName)node);
            if (node is RtRaw) return Visit((RtRaw)node);
            if (node is RtJsdocNode) return Visit((RtJsdocNode)node);
            if (node is RtModule) return Visit((RtModule)node);
            if (node is RtEnumValue) return Visit((RtEnumValue)node);
            if (node is RtEnum) return Visit((RtEnum)node);
            if (node is RtDictionaryType) return Visit((RtDictionaryType)node);
            if (node is RtArrayType) return Visit((RtArrayType)node);
            if (node is RtConstructor) return Visit((RtConstructor)node);
            throw new Exception("Unknown node passed");
        }

        public abstract T Visit(RtField node);
        public abstract T Visit(RtInterface node);
        public abstract T Visit(RtFuncion node);
        public abstract T Visit(RtArgument node);
        public abstract T Visit(RtClass node);
        public abstract T Visit(RtIdentifier node);
        public abstract T Visit(RtDelegateType node);
        public abstract T Visit(RtSimpleTypeName node);
        public abstract T Visit(RtRaw node);
        public abstract T Visit(RtJsdocNode node);
        public abstract T Visit(RtModule node);
        public abstract T Visit(RtEnumValue node);
        public abstract T Visit(RtEnum node);
        public abstract T Visit(RtDictionaryType node);
        public abstract T Visit(RtArrayType node);
        public abstract T Visit(RtConstructor node);
    }
}
