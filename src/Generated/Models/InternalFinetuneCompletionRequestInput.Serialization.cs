// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalFinetuneCompletionRequestInput : IJsonModel<InternalFinetuneCompletionRequestInput>
    {
        void IJsonModel<InternalFinetuneCompletionRequestInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneCompletionRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFinetuneCompletionRequestInput)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Prompt) && _additionalBinaryDataProperties?.ContainsKey("prompt") != true)
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
            }
            if (Optional.IsDefined(Completion) && _additionalBinaryDataProperties?.ContainsKey("completion") != true)
            {
                writer.WritePropertyName("completion"u8);
                writer.WriteStringValue(Completion);
            }
            if (true && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalFinetuneCompletionRequestInput IJsonModel<InternalFinetuneCompletionRequestInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalFinetuneCompletionRequestInput JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneCompletionRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFinetuneCompletionRequestInput)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFinetuneCompletionRequestInput(document.RootElement, options);
        }

        internal static InternalFinetuneCompletionRequestInput DeserializeInternalFinetuneCompletionRequestInput(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string prompt = default;
            string completion = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("prompt"u8))
                {
                    prompt = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("completion"u8))
                {
                    completion = prop.Value.GetString();
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalFinetuneCompletionRequestInput(prompt, completion, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalFinetuneCompletionRequestInput>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneCompletionRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalFinetuneCompletionRequestInput)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFinetuneCompletionRequestInput IPersistableModel<InternalFinetuneCompletionRequestInput>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalFinetuneCompletionRequestInput PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneCompletionRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalFinetuneCompletionRequestInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFinetuneCompletionRequestInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFinetuneCompletionRequestInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalFinetuneCompletionRequestInput internalFinetuneCompletionRequestInput)
        {
            if (internalFinetuneCompletionRequestInput == null)
            {
                return null;
            }
            return BinaryContent.Create(internalFinetuneCompletionRequestInput, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalFinetuneCompletionRequestInput(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalFinetuneCompletionRequestInput(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
