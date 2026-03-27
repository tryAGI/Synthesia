#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TranslationsItem : global::System.IEquatable<TranslationsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Synthesia.TranslationStatusApiItemSuccess? Complete { get; init; }
#else
        public global::Synthesia.TranslationStatusApiItemSuccess? Complete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Complete))]
#endif
        public bool IsComplete => Complete != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Synthesia.TranslationStatusApiItemError? Error { get; init; }
#else
        public global::Synthesia.TranslationStatusApiItemError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranslationsItem(global::Synthesia.TranslationStatusApiItemSuccess value) => new TranslationsItem((global::Synthesia.TranslationStatusApiItemSuccess?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Synthesia.TranslationStatusApiItemSuccess?(TranslationsItem @this) => @this.Complete;

        /// <summary>
        /// 
        /// </summary>
        public TranslationsItem(global::Synthesia.TranslationStatusApiItemSuccess? value)
        {
            Complete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranslationsItem(global::Synthesia.TranslationStatusApiItemError value) => new TranslationsItem((global::Synthesia.TranslationStatusApiItemError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Synthesia.TranslationStatusApiItemError?(TranslationsItem @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public TranslationsItem(global::Synthesia.TranslationStatusApiItemError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslationsItem(
            global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? status,
            global::Synthesia.TranslationStatusApiItemSuccess? complete,
            global::Synthesia.TranslationStatusApiItemError? error
            )
        {
            Status = status;

            Complete = complete;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Complete as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Complete?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComplete && !IsError || !IsComplete && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Synthesia.TranslationStatusApiItemSuccess?, TResult>? complete = null,
            global::System.Func<global::Synthesia.TranslationStatusApiItemError?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComplete && complete != null)
            {
                return complete(Complete!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Synthesia.TranslationStatusApiItemSuccess?>? complete = null,
            global::System.Action<global::Synthesia.TranslationStatusApiItemError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComplete)
            {
                complete?.Invoke(Complete!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Complete,
                typeof(global::Synthesia.TranslationStatusApiItemSuccess),
                Error,
                typeof(global::Synthesia.TranslationStatusApiItemError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TranslationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Synthesia.TranslationStatusApiItemSuccess?>.Default.Equals(Complete, other.Complete) &&
                global::System.Collections.Generic.EqualityComparer<global::Synthesia.TranslationStatusApiItemError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranslationsItem obj1, TranslationsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranslationsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranslationsItem obj1, TranslationsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranslationsItem o && Equals(o);
        }
    }
}
